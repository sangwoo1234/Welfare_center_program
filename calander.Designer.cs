namespace portfolio
{
    partial class calander
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
            this.first_pl = new System.Windows.Forms.FlowLayoutPanel();
            this.sd_lb = new System.Windows.Forms.Label();
            this.md_lb = new System.Windows.Forms.Label();
            this.td_lb = new System.Windows.Forms.Label();
            this.wd_lb = new System.Windows.Forms.Label();
            this.thursd_lb = new System.Windows.Forms.Label();
            this.fd_lb = new System.Windows.Forms.Label();
            this.saturd_lb = new System.Windows.Forms.Label();
            this.nm_btn = new System.Windows.Forms.Button();
            this.pm_btn = new System.Windows.Forms.Button();
            this.lb_month = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drag_lb
            // 
            this.drag_lb.BackColor = System.Drawing.Color.Tan;
            this.drag_lb.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.drag_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drag_lb.Location = new System.Drawing.Point(0, 0);
            this.drag_lb.Name = "drag_lb";
            this.drag_lb.Size = new System.Drawing.Size(1070, 30);
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
            this.exit_btn.Location = new System.Drawing.Point(1070, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // first_pl
            // 
            this.first_pl.Location = new System.Drawing.Point(12, 135);
            this.first_pl.Name = "first_pl";
            this.first_pl.Size = new System.Drawing.Size(1071, 713);
            this.first_pl.TabIndex = 15;
            // 
            // sd_lb
            // 
            this.sd_lb.AutoSize = true;
            this.sd_lb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd_lb.Location = new System.Drawing.Point(42, 99);
            this.sd_lb.Name = "sd_lb";
            this.sd_lb.Size = new System.Drawing.Size(84, 33);
            this.sd_lb.TabIndex = 0;
            this.sd_lb.Text = "일요일";
            // 
            // md_lb
            // 
            this.md_lb.AutoSize = true;
            this.md_lb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.md_lb.Location = new System.Drawing.Point(199, 99);
            this.md_lb.Name = "md_lb";
            this.md_lb.Size = new System.Drawing.Size(84, 33);
            this.md_lb.TabIndex = 16;
            this.md_lb.Text = "월요일";
            // 
            // td_lb
            // 
            this.td_lb.AutoSize = true;
            this.td_lb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.td_lb.Location = new System.Drawing.Point(351, 99);
            this.td_lb.Name = "td_lb";
            this.td_lb.Size = new System.Drawing.Size(84, 33);
            this.td_lb.TabIndex = 0;
            this.td_lb.Text = "화요일";
            // 
            // wd_lb
            // 
            this.wd_lb.AutoSize = true;
            this.wd_lb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wd_lb.Location = new System.Drawing.Point(504, 99);
            this.wd_lb.Name = "wd_lb";
            this.wd_lb.Size = new System.Drawing.Size(84, 33);
            this.wd_lb.TabIndex = 16;
            this.wd_lb.Text = "수요일";
            // 
            // thursd_lb
            // 
            this.thursd_lb.AutoSize = true;
            this.thursd_lb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursd_lb.Location = new System.Drawing.Point(653, 99);
            this.thursd_lb.Name = "thursd_lb";
            this.thursd_lb.Size = new System.Drawing.Size(84, 33);
            this.thursd_lb.TabIndex = 16;
            this.thursd_lb.Text = "목요일";
            // 
            // fd_lb
            // 
            this.fd_lb.AutoSize = true;
            this.fd_lb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fd_lb.Location = new System.Drawing.Point(806, 99);
            this.fd_lb.Name = "fd_lb";
            this.fd_lb.Size = new System.Drawing.Size(84, 33);
            this.fd_lb.TabIndex = 0;
            this.fd_lb.Text = "금요일";
            // 
            // saturd_lb
            // 
            this.saturd_lb.AutoSize = true;
            this.saturd_lb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturd_lb.Location = new System.Drawing.Point(966, 99);
            this.saturd_lb.Name = "saturd_lb";
            this.saturd_lb.Size = new System.Drawing.Size(84, 33);
            this.saturd_lb.TabIndex = 16;
            this.saturd_lb.Text = "토요일";
            // 
            // nm_btn
            // 
            this.nm_btn.FlatAppearance.BorderSize = 0;
            this.nm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nm_btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_btn.ForeColor = System.Drawing.Color.Black;
            this.nm_btn.Location = new System.Drawing.Point(687, 48);
            this.nm_btn.Name = "nm_btn";
            this.nm_btn.Size = new System.Drawing.Size(50, 40);
            this.nm_btn.TabIndex = 0;
            this.nm_btn.Text = "->";
            this.nm_btn.UseVisualStyleBackColor = true;
            this.nm_btn.Click += new System.EventHandler(this.nm_btn_Click);
            // 
            // pm_btn
            // 
            this.pm_btn.FlatAppearance.BorderSize = 0;
            this.pm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pm_btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm_btn.ForeColor = System.Drawing.Color.Black;
            this.pm_btn.Location = new System.Drawing.Point(357, 48);
            this.pm_btn.Name = "pm_btn";
            this.pm_btn.Size = new System.Drawing.Size(50, 40);
            this.pm_btn.TabIndex = 17;
            this.pm_btn.Text = "<-";
            this.pm_btn.UseVisualStyleBackColor = true;
            this.pm_btn.Click += new System.EventHandler(this.pm_btn_Click);
            // 
            // lb_month
            // 
            this.lb_month.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_month.Location = new System.Drawing.Point(480, 48);
            this.lb_month.Name = "lb_month";
            this.lb_month.Size = new System.Drawing.Size(184, 33);
            this.lb_month.TabIndex = 16;
            this.lb_month.Text = "Month YEAR";
            // 
            // calander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.lb_month);
            this.Controls.Add(this.pm_btn);
            this.Controls.Add(this.nm_btn);
            this.Controls.Add(this.saturd_lb);
            this.Controls.Add(this.fd_lb);
            this.Controls.Add(this.wd_lb);
            this.Controls.Add(this.thursd_lb);
            this.Controls.Add(this.td_lb);
            this.Controls.Add(this.md_lb);
            this.Controls.Add(this.sd_lb);
            this.Controls.Add(this.first_pl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.drag_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calander";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calander";
            this.Load += new System.EventHandler(this.calander_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label drag_lb;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.FlowLayoutPanel first_pl;
        private System.Windows.Forms.Label sd_lb;
        private System.Windows.Forms.Label md_lb;
        private System.Windows.Forms.Label td_lb;
        private System.Windows.Forms.Label wd_lb;
        private System.Windows.Forms.Label thursd_lb;
        private System.Windows.Forms.Label fd_lb;
        private System.Windows.Forms.Label saturd_lb;
        private System.Windows.Forms.Button nm_btn;
        private System.Windows.Forms.Button pm_btn;
        private System.Windows.Forms.Label lb_month;
    }
}