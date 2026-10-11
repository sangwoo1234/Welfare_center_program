namespace portfolio
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drag_lb = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calander_btn = new System.Windows.Forms.Button();
            this.leave_btn = new System.Windows.Forms.Button();
            this.arrive_btn = new System.Windows.Forms.Button();
            this.car_registered_btn = new System.Windows.Forms.Button();
            this.car_regist_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clock_lb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drag_lb
            // 
            this.drag_lb.BackColor = System.Drawing.Color.Tan;
            this.drag_lb.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.drag_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drag_lb.Location = new System.Drawing.Point(0, 0);
            this.drag_lb.Name = "drag_lb";
            this.drag_lb.Size = new System.Drawing.Size(1170, 30);
            this.drag_lb.TabIndex = 12;
            this.drag_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drag_lb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_lb_MouseDown);
            this.drag_lb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_lb_MouseMove);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Tan;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(1170, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 13;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.calander_btn);
            this.panel1.Controls.Add(this.leave_btn);
            this.panel1.Controls.Add(this.arrive_btn);
            this.panel1.Controls.Add(this.car_registered_btn);
            this.panel1.Controls.Add(this.car_regist_btn);
            this.panel1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(50, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 550);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // calander_btn
            // 
            this.calander_btn.BackColor = System.Drawing.Color.Wheat;
            this.calander_btn.FlatAppearance.BorderSize = 0;
            this.calander_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calander_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calander_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calander_btn.Location = new System.Drawing.Point(402, 235);
            this.calander_btn.Name = "calander_btn";
            this.calander_btn.Size = new System.Drawing.Size(294, 125);
            this.calander_btn.TabIndex = 16;
            this.calander_btn.Text = "캘린더";
            this.calander_btn.UseVisualStyleBackColor = false;
            this.calander_btn.Click += new System.EventHandler(this.calander_btn_Click);
            // 
            // leave_btn
            // 
            this.leave_btn.BackColor = System.Drawing.Color.Wheat;
            this.leave_btn.FlatAppearance.BorderSize = 0;
            this.leave_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leave_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leave_btn.Location = new System.Drawing.Point(702, 235);
            this.leave_btn.Name = "leave_btn";
            this.leave_btn.Size = new System.Drawing.Size(150, 125);
            this.leave_btn.TabIndex = 16;
            this.leave_btn.Text = "퇴근";
            this.leave_btn.UseVisualStyleBackColor = false;
            this.leave_btn.Click += new System.EventHandler(this.leave_btn_Click);
            // 
            // arrive_btn
            // 
            this.arrive_btn.BackColor = System.Drawing.Color.Wheat;
            this.arrive_btn.FlatAppearance.BorderSize = 0;
            this.arrive_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrive_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrive_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.arrive_btn.Location = new System.Drawing.Point(246, 235);
            this.arrive_btn.Name = "arrive_btn";
            this.arrive_btn.Size = new System.Drawing.Size(150, 125);
            this.arrive_btn.TabIndex = 16;
            this.arrive_btn.Text = "출근";
            this.arrive_btn.UseVisualStyleBackColor = false;
            this.arrive_btn.Click += new System.EventHandler(this.arrive_btn_Click);
            // 
            // car_registered_btn
            // 
            this.car_registered_btn.BackColor = System.Drawing.Color.Wheat;
            this.car_registered_btn.FlatAppearance.BorderSize = 0;
            this.car_registered_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car_registered_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_registered_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.car_registered_btn.Location = new System.Drawing.Point(552, 79);
            this.car_registered_btn.Name = "car_registered_btn";
            this.car_registered_btn.Size = new System.Drawing.Size(300, 150);
            this.car_registered_btn.TabIndex = 16;
            this.car_registered_btn.Text = "등록된 차량";
            this.car_registered_btn.UseVisualStyleBackColor = false;
            this.car_registered_btn.Click += new System.EventHandler(this.car_registered_btn_Click);
            // 
            // car_regist_btn
            // 
            this.car_regist_btn.BackColor = System.Drawing.Color.Wheat;
            this.car_regist_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.car_regist_btn.FlatAppearance.BorderSize = 0;
            this.car_regist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car_regist_btn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_regist_btn.ForeColor = System.Drawing.Color.Black;
            this.car_regist_btn.Location = new System.Drawing.Point(246, 79);
            this.car_regist_btn.Name = "car_regist_btn";
            this.car_regist_btn.Size = new System.Drawing.Size(300, 150);
            this.car_regist_btn.TabIndex = 16;
            this.car_regist_btn.Text = "차량등록";
            this.car_regist_btn.UseVisualStyleBackColor = false;
            this.car_regist_btn.Click += new System.EventHandler(this.car_regist_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.ClockEvent);
            // 
            // clock_lb
            // 
            this.clock_lb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_lb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clock_lb.Location = new System.Drawing.Point(0, 30);
            this.clock_lb.Name = "clock_lb";
            this.clock_lb.Size = new System.Drawing.Size(300, 35);
            this.clock_lb.TabIndex = 15;
            this.clock_lb.Text = "clock";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.clock_lb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.drag_lb);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label drag_lb;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clock_lb;
        private System.Windows.Forms.Button car_regist_btn;
        private System.Windows.Forms.Button calander_btn;
        private System.Windows.Forms.Button arrive_btn;
        private System.Windows.Forms.Button car_registered_btn;
        private System.Windows.Forms.Button leave_btn;
    }
}