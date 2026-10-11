namespace portfolio
{
    partial class car_regist
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
            this.drag_lb = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_dtp = new System.Windows.Forms.DateTimePicker();
            this.rg_btn = new System.Windows.Forms.Button();
            this.namae_tb = new System.Windows.Forms.TextBox();
            this.ct_tb = new System.Windows.Forms.TextBox();
            this.color_tb = new System.Windows.Forms.TextBox();
            this.cn_tb = new System.Windows.Forms.TextBox();
            this.num_tb_2 = new System.Windows.Forms.TextBox();
            this.subject_tb = new System.Windows.Forms.TextBox();
            this.namae_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_tb_1 = new System.Windows.Forms.TextBox();
            this.num_tb_3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drag_lb
            // 
            this.drag_lb.BackColor = System.Drawing.Color.Tan;
            this.drag_lb.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.drag_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drag_lb.Location = new System.Drawing.Point(0, 0);
            this.drag_lb.Name = "drag_lb";
            this.drag_lb.Size = new System.Drawing.Size(970, 30);
            this.drag_lb.TabIndex = 13;
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
            this.exit_btn.Location = new System.Drawing.Point(970, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(425, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "차량등록";
            // 
            // rd_dtp
            // 
            this.rd_dtp.CalendarFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_dtp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_dtp.Location = new System.Drawing.Point(739, 156);
            this.rd_dtp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.rd_dtp.Name = "rd_dtp";
            this.rd_dtp.Size = new System.Drawing.Size(153, 26);
            this.rd_dtp.TabIndex = 8;
            // 
            // rg_btn
            // 
            this.rg_btn.BackColor = System.Drawing.SystemColors.Info;
            this.rg_btn.FlatAppearance.BorderSize = 0;
            this.rg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rg_btn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg_btn.Location = new System.Drawing.Point(375, 350);
            this.rg_btn.Name = "rg_btn";
            this.rg_btn.Size = new System.Drawing.Size(250, 50);
            this.rg_btn.TabIndex = 9;
            this.rg_btn.Text = "등록";
            this.rg_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rg_btn.UseVisualStyleBackColor = false;
            this.rg_btn.Click += new System.EventHandler(this.rg_btn_Click);
            // 
            // namae_tb
            // 
            this.namae_tb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namae_tb.Location = new System.Drawing.Point(192, 156);
            this.namae_tb.MaxLength = 4;
            this.namae_tb.Name = "namae_tb";
            this.namae_tb.Size = new System.Drawing.Size(75, 26);
            this.namae_tb.TabIndex = 0;
            // 
            // ct_tb
            // 
            this.ct_tb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_tb.Location = new System.Drawing.Point(192, 226);
            this.ct_tb.MaxLength = 15;
            this.ct_tb.Name = "ct_tb";
            this.ct_tb.Size = new System.Drawing.Size(75, 26);
            this.ct_tb.TabIndex = 1;
            // 
            // color_tb
            // 
            this.color_tb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_tb.Location = new System.Drawing.Point(192, 296);
            this.color_tb.MaxLength = 5;
            this.color_tb.Name = "color_tb";
            this.color_tb.Size = new System.Drawing.Size(75, 26);
            this.color_tb.TabIndex = 2;
            // 
            // cn_tb
            // 
            this.cn_tb.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cn_tb.Location = new System.Drawing.Point(398, 156);
            this.cn_tb.MaxLength = 14;
            this.cn_tb.Name = "cn_tb";
            this.cn_tb.Size = new System.Drawing.Size(108, 26);
            this.cn_tb.TabIndex = 3;
            // 
            // num_tb_2
            // 
            this.num_tb_2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.num_tb_2.Location = new System.Drawing.Point(466, 226);
            this.num_tb_2.MaxLength = 4;
            this.num_tb_2.Name = "num_tb_2";
            this.num_tb_2.Size = new System.Drawing.Size(55, 26);
            this.num_tb_2.TabIndex = 5;
            // 
            // subject_tb
            // 
            this.subject_tb.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.subject_tb.Location = new System.Drawing.Point(398, 296);
            this.subject_tb.MaxLength = 255;
            this.subject_tb.Name = "subject_tb";
            this.subject_tb.Size = new System.Drawing.Size(154, 26);
            this.subject_tb.TabIndex = 7;
            // 
            // namae_lb
            // 
            this.namae_lb.AutoSize = true;
            this.namae_lb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namae_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.namae_lb.Location = new System.Drawing.Point(192, 131);
            this.namae_lb.Name = "namae_lb";
            this.namae_lb.Size = new System.Drawing.Size(33, 19);
            this.namae_lb.TabIndex = 20;
            this.namae_lb.Text = "성명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(192, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "차종";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(192, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "색상";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(398, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "차량번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(398, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "전화번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(398, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "수강과목";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(450, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(524, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "-";
            // 
            // num_tb_1
            // 
            this.num_tb_1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.num_tb_1.Location = new System.Drawing.Point(402, 225);
            this.num_tb_1.MaxLength = 4;
            this.num_tb_1.Name = "num_tb_1";
            this.num_tb_1.Size = new System.Drawing.Size(45, 26);
            this.num_tb_1.TabIndex = 4;
            // 
            // num_tb_3
            // 
            this.num_tb_3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.num_tb_3.Location = new System.Drawing.Point(541, 226);
            this.num_tb_3.MaxLength = 4;
            this.num_tb_3.Name = "num_tb_3";
            this.num_tb_3.Size = new System.Drawing.Size(55, 26);
            this.num_tb_3.TabIndex = 6;
            // 
            // car_regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.subject_tb);
            this.Controls.Add(this.num_tb_1);
            this.Controls.Add(this.num_tb_3);
            this.Controls.Add(this.num_tb_2);
            this.Controls.Add(this.cn_tb);
            this.Controls.Add(this.color_tb);
            this.Controls.Add(this.ct_tb);
            this.Controls.Add(this.namae_tb);
            this.Controls.Add(this.rg_btn);
            this.Controls.Add(this.rd_dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.drag_lb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namae_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "car_regist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "car_regist";
            this.Load += new System.EventHandler(this.car_regist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label drag_lb;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker rd_dtp;
        private System.Windows.Forms.Button rg_btn;
        private System.Windows.Forms.TextBox namae_tb;
        private System.Windows.Forms.TextBox ct_tb;
        private System.Windows.Forms.TextBox color_tb;
        private System.Windows.Forms.TextBox cn_tb;
        private System.Windows.Forms.TextBox num_tb_2;
        private System.Windows.Forms.TextBox subject_tb;
        private System.Windows.Forms.Label namae_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox num_tb_1;
        private System.Windows.Forms.TextBox num_tb_3;
    }
}