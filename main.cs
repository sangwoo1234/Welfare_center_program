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
    public partial class main : Form
    {
        private Point mousePoint;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string strConn = "Server=yourdatabase; database=db; user id=test; password=test;";
        int user_id;
        string namae;
        public main(int userId, string namaeValue)
        {
            InitializeComponent();
            timer1.Start();

            user_id = userId;
            namae = namaeValue;
        }
        private void main_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
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

        private void ClockEvent(object sender, EventArgs e)
        {
            clock_lb.Text = DateTime.Now.ToString();
        }

        private void car_regist_btn_Click(object sender, EventArgs e)
        {
            car_regist subform = new car_regist(user_id, namae);
            subform.ShowDialog();
        }

        private void car_registered_btn_Click(object sender, EventArgs e)
        {
            registed_car subform = new registed_car(user_id);
            subform.ShowDialog();
        }

        private void arrive_btn_Click(object sender, EventArgs e)
        {
            //1번으로 현재시간 데이터를 sendtodb_arrive에 넘겨주고
            DateTime arrivetime = DateTime.Now;
            //2번으로 그 시간을 넘겨주고 함수 실행
            sendtodb_arrive(arrivetime);
            
        }
        //3번 받은 시간으로 Sql에 데이터 저장
        private void sendtodb_arrive(DateTime arrivetime)
        {
            //sql을 굳이 하나만 써야하는 이유가 없다 아래처럼 checkSql insertSql2개를 만들고 한 함수에 2번의 Sql문장 호출이 가능함
            //중복체크용 Sql
            string checkSql = @"SELECT COUNT(*) FROM commute WHERE user_id = @user_id AND CONVERT(date, arrive_time) = CONVERT(date, GETDATE())";

            SqlCommand checkCmd = new SqlCommand(checkSql, conn);
            checkCmd.Parameters.AddWithValue("@user_id", user_id);

            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("오늘은 이미 출근했습니다.", "사회복무요원");
                return;
            }

            // 출근 INSERT
            string insertSql = @"INSERT INTO commute(user_id, arrive_time) VALUES (@user_id, @Arrivetime)";

            SqlCommand cmd = new SqlCommand(insertSql, conn);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            cmd.Parameters.AddWithValue("@Arrivetime", arrivetime);
            MessageBox.Show("출근 완료!", "사회복무요원");

            cmd.ExecuteNonQuery();
        }
        private void leave_btn_Click(object sender, EventArgs e)
        {
            DateTime leavetime = DateTime.Now;
            sendtodb_leave(leavetime);
        }
        private void sendtodb_leave(DateTime leavetime)
        {
            string sql = @"UPDATE commute SET leave_time = @Leavetime WHERE user_id = @user_id AND CONVERT(date, arrive_time) = CONVERT(date, GETDATE()) AND leave_time IS NULL";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            cmd.Parameters.AddWithValue("@Leavetime", leavetime);

            int result = cmd.ExecuteNonQuery();

            if (result != 0)
            {
                MessageBox.Show("퇴근 완료!", "사회복무요원");
            }
            else
            {
                MessageBox.Show("이미 퇴근했거나 출근 기록이 없습니다.", "사회복무요원");
            }
        }

        private void calander_btn_Click(object sender, EventArgs e)
        {
            calander subform = new calander(user_id);
            subform.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

