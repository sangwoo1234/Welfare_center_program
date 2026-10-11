namespace portfolio
{
    partial class regist
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.drag_lb = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.pw_tb = new System.Windows.Forms.TextBox();
            this.pw_lb = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regist_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.namae_lb = new System.Windows.Forms.Label();
            this.namae_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // drag_lb
            // 
            this.drag_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.drag_lb.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.drag_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drag_lb.Location = new System.Drawing.Point(0, 0);
            this.drag_lb.Name = "drag_lb";
            this.drag_lb.Size = new System.Drawing.Size(370, 30);
            this.drag_lb.TabIndex = 14;
            this.drag_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drag_lb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_lb_MouseDown);
            this.drag_lb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_lb_MouseMove);
            // 
            // id_tb
            // 
            this.id_tb.BackColor = System.Drawing.SystemColors.Control;
            this.id_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.id_tb.Location = new System.Drawing.Point(75, 260);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(250, 20);
            this.id_tb.TabIndex = 2;
            this.id_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_tb_KeyDown);
            // 
            // pw_tb
            // 
            this.pw_tb.BackColor = System.Drawing.SystemColors.Control;
            this.pw_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pw_tb.Location = new System.Drawing.Point(75, 350);
            this.pw_tb.Name = "pw_tb";
            this.pw_tb.Size = new System.Drawing.Size(250, 20);
            this.pw_tb.TabIndex = 3;
            this.pw_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pw_tb_KeyDown);
            // 
            // pw_lb
            // 
            this.pw_lb.AutoSize = true;
            this.pw_lb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pw_lb.Location = new System.Drawing.Point(75, 320);
            this.pw_lb.Name = "pw_lb";
            this.pw_lb.Size = new System.Drawing.Size(67, 18);
            this.pw_lb.TabIndex = 34;
            this.pw_lb.Text = "Password";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.id_lb.Location = new System.Drawing.Point(75, 230);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(21, 18);
            this.id_lb.TabIndex = 35;
            this.id_lb.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(75, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(75, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 33;
            // 
            // regist_btn
            // 
            this.regist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.regist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regist_btn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.regist_btn.ForeColor = System.Drawing.Color.Black;
            this.regist_btn.Location = new System.Drawing.Point(125, 420);
            this.regist_btn.Name = "regist_btn";
            this.regist_btn.Size = new System.Drawing.Size(150, 60);
            this.regist_btn.TabIndex = 4;
            this.regist_btn.Text = "등록";
            this.regist_btn.UseVisualStyleBackColor = false;
            this.regist_btn.Click += new System.EventHandler(this.regist_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(75, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 32;
            // 
            // namae_lb
            // 
            this.namae_lb.AutoSize = true;
            this.namae_lb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namae_lb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.namae_lb.Location = new System.Drawing.Point(75, 140);
            this.namae_lb.Name = "namae_lb";
            this.namae_lb.Size = new System.Drawing.Size(45, 18);
            this.namae_lb.TabIndex = 35;
            this.namae_lb.Text = "Name";
            // 
            // namae_tb
            // 
            this.namae_tb.BackColor = System.Drawing.SystemColors.Control;
            this.namae_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namae_tb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namae_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.namae_tb.Location = new System.Drawing.Point(75, 170);
            this.namae_tb.Name = "namae_tb";
            this.namae_tb.Size = new System.Drawing.Size(250, 20);
            this.namae_tb.TabIndex = 1;
            this.namae_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namae_tb_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "공익";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 75);
            this.panel4.TabIndex = 38;
            // 
            // regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 530);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.namae_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.pw_tb);
            this.Controls.Add(this.pw_lb);
            this.Controls.Add(this.namae_lb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regist_btn);
            this.Controls.Add(this.drag_lb);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "regist";
            this.Load += new System.EventHandler(this.regist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label drag_lb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox pw_tb;
        private System.Windows.Forms.Label pw_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button regist_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label namae_lb;
        private System.Windows.Forms.TextBox namae_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}