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
using System.Text.RegularExpressions;

namespace portfolio
{
    public partial class car_regist : Form
    {
        private Point mousePoint;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string strConn = "Server=yourdatabase; database=db; user id=test; password=test;";

        int user_id;
        string namae;

        public car_regist(int userId, string namaeValue)
        {
            InitializeComponent();

            user_id = userId;
            namae = namaeValue;
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
        private void car_regist_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        private void rg_btn_Click(object sender, EventArgs e)
        {
            string num = num_tb_1.Text + "-" + num_tb_2.Text + "-" + num_tb_3.Text;

            string sql = @"INSERT INTO car (user_id, guest_namae, car_number, car_type, color, contact, regist_date, subject)VALUES (@user_id, @guest_namae, @car_number, @car_type, @color, @contact, @regist_date, @subject)";
            string checkdistinct = @"SELECT COUNT(*) FROM car WHERE guest_namae = @guest_namae";//이용자 중복확인을 위한 sql문



            if (Regex.IsMatch(namae_tb.Text, @"[\p{IsBasicLatin}\p{IsLatin-1Supplement}\p{IsLatinExtended-A}\p{IsLatinExtended-B}]"))
            {
                MessageBox.Show("한글만 입력해주세요.", "사회복무요원");
                return;
            }
            else if (Regex.IsMatch(color_tb.Text, @"[\p{IsBasicLatin}\p{IsLatin-1Supplement}\p{IsLatinExtended-A}\p{IsLatinExtended-B}]"))
            {
                MessageBox.Show("한글만 입력해주세요.", "사회복무요원");
                return;
            }
            SqlCommand cdup = new SqlCommand(checkdistinct, conn);//이용자 중복확인
            cdup.Parameters.AddWithValue("@guest_namae", namae_tb.Text);

            int count = (int)cdup.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("이미 등록된 회원입니다.", "사회복무요원");
                return;
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            cmd.Parameters.AddWithValue("@guest_namae", namae_tb.Text);
            cmd.Parameters.AddWithValue("@car_number", cn_tb.Text);
            cmd.Parameters.AddWithValue("@car_type", ct_tb.Text);
            cmd.Parameters.AddWithValue("@color", color_tb.Text);
            cmd.Parameters.AddWithValue("@subject", subject_tb.Text);
            cmd.Parameters.AddWithValue("@contact", num);
            cmd.Parameters.AddWithValue("@regist_date", DateTime.Now);
            cmd.ExecuteNonQuery();
            MessageBox.Show("등록 완료되었습니다", "사회복무요원");


        }
    }
}
