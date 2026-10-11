using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace portfolio
{
    public partial class registed_car : Form
    {
        private Point mousePoint;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string strConn = "Server=yourdatabase; database=db; user id=test; password=test;";
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();


        int user_id;

        public registed_car(int userId)
        {
            InitializeComponent();
            user_id = userId;
        }

        private void registed_car_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();

            string sql = @"SELECT 
                           c.car_id,
                           c.guest_namae,
                           c.car_number,
                           c.car_type,
                           c.color,
                           c.contact,
                           c.subject,
                           c.regist_date,
                           g.namae FROM car c JOIN guser g ON c.user_id = g.user_id";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user_id", user_id);

            da.SelectCommand = cmd;

            da.Fill(ds, "car");
            dataGridView1.DataSource = ds.Tables["car"];

            conn.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 행을 선택하세요.", "사회복무요원");
                return;
            }

            bool hasSuccess = false;
            bool hasFail = false;

            try
            {
                conn.Open();

                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    if (selectedRow.Cells["car_id"].Value == null)
                        continue;

                    int car_id = Convert.ToInt32(selectedRow.Cells[0].Value);

                    string sql = "DELETE FROM car WHERE car_id = @car_id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@car_id", car_id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            hasSuccess = true;

                            DataRow[] rows = ds.Tables["car"].Select("car_id = " + car_id);

                            foreach (DataRow row in rows)
                            {
                                ds.Tables["car"].Rows.Remove(row);
                            }
                        }
                        else
                        {
                            hasFail = true;
                        }
                    }
                }

                ds.Tables["car"].AcceptChanges();

                //결과 메시지 정리
                if (hasSuccess && hasFail)
                    MessageBox.Show("일부 삭제 성공, 일부 실패", "사회복무요원");
                else if (hasSuccess)
                    MessageBox.Show("삭제 완료!", "사회복무요원");
                else
                    MessageBox.Show("삭제 실패", "사회복무요원");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // 현재 DataGridView에서 수정 중인 셀의 값을 확정
            dataGridView1.EndEdit();

            DataTable changedDataTable = ds.Tables["car"].GetChanges();

            if (changedDataTable == null)
            {
                MessageBox.Show(
                    "변경된 내용이 없습니다.",
                    "사회복무요원",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            try
            {
                using (conn = new SqlConnection(strConn))
                {
                    conn.Open();

                    string sql = @"
                    UPDATE car
                    SET guest_namae = @guest_namae,
                    car_number = @car_number,
                    car_type = @car_type,
                    color = @color,
                    contact = @contact,
                    regist_date = @regist_date,
                    subject = @subject
                    WHERE car_id = @car_id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@guest_namae", SqlDbType.NVarChar).SourceColumn = "guest_namae";
                        cmd.Parameters.Add("@car_number", SqlDbType.NVarChar).SourceColumn = "car_number";
                        cmd.Parameters.Add("@car_type", SqlDbType.NVarChar).SourceColumn = "car_type";
                        cmd.Parameters.Add("@color", SqlDbType.NVarChar).SourceColumn = "color";
                        cmd.Parameters.Add("@contact", SqlDbType.NVarChar).SourceColumn = "contact";
                        cmd.Parameters.Add("@regist_date", SqlDbType.Date).SourceColumn = "regist_date";
                        cmd.Parameters.Add("@subject", SqlDbType.NVarChar).SourceColumn = "subject";

                        SqlParameter carIdParameter = cmd.Parameters.Add("@car_id", SqlDbType.Int);

                        carIdParameter.SourceColumn = "car_id";
                        carIdParameter.SourceVersion = DataRowVersion.Original;

                        da.UpdateCommand = cmd;

                        da.Update(changedDataTable);
                    }
                }

                // DB 반영이 성공한 경우에만 변경사항을 확정
                ds.Tables["car"].AcceptChanges();

                MessageBox.Show(
                    "변경사항이 성공적으로 저장되었습니다.",
                    "사회복무요원",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "변경사항 저장 중 오류가 발생했습니다.\n\n" + ex.Message,
                    "사회복무요원",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void drag_lb_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //현재 마우스 좌표 저장
        }
        private void drag_lb_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) //마우스 왼쪽 클릭 시에만 실행
            {
                //폼의 위치를 드래그중인 마우스의 좌표로 이동 
                Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
