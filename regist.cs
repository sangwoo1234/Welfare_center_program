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
    public partial class regist : Form
    {
        private Point mousePoint;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string strConn = "Server=yourdatabase; database=db; user id=test; password=test;";
        public regist()
        {
            InitializeComponent();
        }
        private void regist_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            conn = new SqlConnection(strConn);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            
        }
        private void regist_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM guser WHERE namae = '" + namae_tb.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int namae_count = (int)cmd.ExecuteScalar();

            if (namae_tb.Text == "")
            {
                MessageBox.Show("공백을 없애주세요.", "사회복무요원");
                return;
            }
            else if (namae_tb.Text.Length > 5)
            {
                MessageBox.Show("이름은 5자내의 한글만 사용 가능합니다");
                return;
            }
            else if (namae_count > 0)
            {
                MessageBox.Show("중복된 이름이 있습니다", "사회복무요원");
                return;
            }
            else if (Regex.IsMatch(namae_tb.Text, @"[\p{IsBasicLatin}\p{IsLatin-1Supplement}\p{IsLatinExtended-A}\p{IsLatinExtended-B}]"))
            {
                MessageBox.Show("한글 이름만 입력해주세요.", "사회복무요원");
                return;
            }

            sql = "SELECT COUNT(*) FROM guser WHERE id = '" + id_tb.Text + "'";
            cmd = new SqlCommand(sql, conn);
            int id_count = (int)cmd.ExecuteScalar();

            if (id_tb.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.", "사회복무요원");
                return;
            }
            else if (id_tb.Text.Length > 20 || id_tb.Text.Length < 5)
            {
                MessageBox.Show("아이디는 5~20자의 영문,숫자만 사용 가능합니다");
                return;
            }
            else if (!Regex.IsMatch(id_tb.Text, @"^[A-Za-z0-9]+$"))
            {
                MessageBox.Show("영어와 숫자만 입력해주세요.", "사회복무요원");
                return;
            }
            else if (!Regex.IsMatch(id_tb.Text, @"[A-Za-z]"))
            {
                MessageBox.Show("최소 한 개의 영어를 포함해주세요.", "사회복무요원");
                return;
            }
            else if (id_count > 0)
            {
                MessageBox.Show("중복된 아이디가 있습니다", "사회복무요원");
                return;
            }

            if (pw_tb.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.", "사회복무요원");
                return;
            }
            else if (!Regex.IsMatch(pw_tb.Text, @"^[A-Za-z0-9]+$"))
            {
                MessageBox.Show("영어와 숫자만 입력해주세요.", "사회복무요원");
                return;
            }
            else if (pw_tb.Text.Length > 20 || pw_tb.Text.Length < 5)
            {
                MessageBox.Show("비밀번호는 5~20자의 영문,숫자만 사용 가능합니다");
                return;
            }

            sql = "INSERT INTO guser VALUES('" + id_tb.Text + "','" + pw_tb.Text + "', '" + namae_tb.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteScalar();
            MessageBox.Show("등록되었습니다.","사회복무요원");
            this.Close();

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void namae_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터키를 입력받으면 실행
            {
                id_tb.Focus();//다음 textbox로 포커스
                e.Handled = true;
            } 
        }
        private void id_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터키를 입력받으면 실행
            {
                pw_tb.Focus();//다음 textbox로 포커스
                e.Handled = true;
            }
        }
        private void pw_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터키를 입력받으면 실행
            {
                regist_btn_Click(sender, e);
            }
        }
    }
}
