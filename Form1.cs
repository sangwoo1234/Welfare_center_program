using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql사용을 위한 선언문
using System.Text.RegularExpressions;

namespace portfolio
{
    public partial class Form1 : Form
    {
        private Point mousePoint;
        SqlConnection conn = null;//sql문 사용을 위한 초기화
        SqlCommand cmd = null;
        string strConn = "Server=yourdatabase; database=db; user id=test; password=test;";//집에있는 ip로 mssql 서버접속을 위해 strConn 변수에 저장
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConn);//sql문에 ip정보를 넘겨줌
                conn.Open();//데이터베이스 연결 함수
                cmd = new SqlCommand();
                cmd.Connection = conn;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT user_id, namae FROM guser WHERE id = @id AND pw = @pw";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id_tb.Text);
            cmd.Parameters.AddWithValue("@pw", pw_tb.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int user_id = reader.GetInt32(0);
                string namae = reader.GetString(1);

                MessageBox.Show(namae + "님 반갑습니다", "사회복무요원");

                main subForm = new main(user_id, namae);
                reader.Close();
                subForm.ShowDialog();
            }
            else
            {
                reader.Close();
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "사회복무요원");
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
        private void id_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pw_tb.Focus();
                e.Handled = true;
            }
        }
        private void pw_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login_btn_Click(sender, e);
            }
        }
        private void regist_lb_Click(object sender, EventArgs e)
        {
            regist subform = new regist();
            subform.ShowDialog();
        }
    }
}
