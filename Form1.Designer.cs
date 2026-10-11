namespace portfolio
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_btn = new System.Windows.Forms.Button();
            this.regist_lb = new System.Windows.Forms.Label();
            this.drag_lb = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_lb = new System.Windows.Forms.Label();
            this.pw_lb = new System.Windows.Forms.Label();
            this.pw_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.Location = new System.Drawing.Point(125, 373);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(150, 60);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // regist_lb
            // 
            this.regist_lb.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.regist_lb.Location = new System.Drawing.Point(0, 500);
            this.regist_lb.Name = "regist_lb";
            this.regist_lb.Size = new System.Drawing.Size(70, 30);
            this.regist_lb.TabIndex = 10;
            this.regist_lb.Text = "등록";
            this.regist_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regist_lb.Click += new System.EventHandler(this.regist_lb_Click);
            // 
            // drag_lb
            // 
            this.drag_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.drag_lb.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.drag_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drag_lb.Location = new System.Drawing.Point(0, 0);
            this.drag_lb.Name = "drag_lb";
            this.drag_lb.Size = new System.Drawing.Size(370, 30);
            this.drag_lb.TabIndex = 11;
            this.drag_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drag_lb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_lb_MouseDown);
            this.drag_lb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_lb_MouseMove);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(370, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(75, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(75, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 13;
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id_lb.Location = new System.Drawing.Point(75, 185);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(21, 18);
            this.id_lb.TabIndex = 14;
            this.id_lb.Text = "ID";
            // 
            // pw_lb
            // 
            this.pw_lb.AutoSize = true;
            this.pw_lb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pw_lb.Location = new System.Drawing.Point(75, 275);
            this.pw_lb.Name = "pw_lb";
            this.pw_lb.Size = new System.Drawing.Size(67, 18);
            this.pw_lb.TabIndex = 14;
            this.pw_lb.Text = "Password";
            // 
            // pw_tb
            // 
            this.pw_tb.BackColor = System.Drawing.SystemColors.Control;
            this.pw_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pw_tb.Location = new System.Drawing.Point(75, 305);
            this.pw_tb.Name = "pw_tb";
            this.pw_tb.Size = new System.Drawing.Size(250, 20);
            this.pw_tb.TabIndex = 2;
            this.pw_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pw_tb_KeyDown);
            // 
            // id_tb
            // 
            this.id_tb.BackColor = System.Drawing.SystemColors.Control;
            this.id_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.id_tb.Location = new System.Drawing.Point(75, 215);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(250, 20);
            this.id_tb.TabIndex = 1;
            this.id_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_tb_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::portfolio.Properties.Resources.img;
            this.pictureBox1.Location = new System.Drawing.Point(-100, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 130);
            this.panel3.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(400, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.pw_tb);
            this.Controls.Add(this.pw_lb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.drag_lb);
            this.Controls.Add(this.regist_lb);
            this.Controls.Add(this.login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사회복무요원";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label regist_lb;
        private System.Windows.Forms.Label drag_lb;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label pw_lb;
        private System.Windows.Forms.TextBox pw_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}

