namespace portfolio
{
    partial class registed_car
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit_btn = new System.Windows.Forms.Button();
            this.drag_lb = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.car_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bokji_namae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regist_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.car_id,
            this.bokji_namae,
            this.car_type,
            this.color,
            this.car_num,
            this.phone_num,
            this.sign_subject,
            this.regist_day,
            this.namae});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(30, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(940, 336);
            this.dataGridView1.TabIndex = 0;
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
            this.exit_btn.TabIndex = 15;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // drag_lb
            // 
            this.drag_lb.BackColor = System.Drawing.Color.Tan;
            this.drag_lb.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.drag_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drag_lb.Location = new System.Drawing.Point(0, 0);
            this.drag_lb.Name = "drag_lb";
            this.drag_lb.Size = new System.Drawing.Size(970, 30);
            this.drag_lb.TabIndex = 16;
            this.drag_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drag_lb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_lb_MouseDown);
            this.drag_lb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_lb_MouseMove);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(171, 544);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 17;
            this.update_btn.Text = "수정";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(804, 544);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 17;
            this.delete_btn.Text = "삭제";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "차적현황";
            // 
            // car_id
            // 
            this.car_id.DataPropertyName = "car_id";
            this.car_id.HeaderText = "번호";
            this.car_id.Name = "car_id";
            this.car_id.Width = 35;
            // 
            // bokji_namae
            // 
            this.bokji_namae.DataPropertyName = "guest_namae";
            this.bokji_namae.HeaderText = "성명";
            this.bokji_namae.Name = "bokji_namae";
            this.bokji_namae.Width = 70;
            // 
            // car_type
            // 
            this.car_type.DataPropertyName = "car_type";
            this.car_type.HeaderText = "차종";
            this.car_type.Name = "car_type";
            this.car_type.Width = 70;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "색상";
            this.color.Name = "color";
            this.color.Width = 70;
            // 
            // car_num
            // 
            this.car_num.DataPropertyName = "car_number";
            this.car_num.HeaderText = "차량번호";
            this.car_num.Name = "car_num";
            this.car_num.Width = 130;
            // 
            // phone_num
            // 
            this.phone_num.DataPropertyName = "contact";
            this.phone_num.HeaderText = "전화번호";
            this.phone_num.Name = "phone_num";
            this.phone_num.Width = 130;
            // 
            // sign_subject
            // 
            this.sign_subject.DataPropertyName = "subject";
            this.sign_subject.HeaderText = "수강과목";
            this.sign_subject.Name = "sign_subject";
            this.sign_subject.Width = 130;
            // 
            // regist_day
            // 
            this.regist_day.DataPropertyName = "regist_date";
            this.regist_day.HeaderText = "등록일";
            this.regist_day.Name = "regist_day";
            this.regist_day.Width = 150;
            // 
            // namae
            // 
            this.namae.DataPropertyName = "namae";
            this.namae.FillWeight = 50F;
            this.namae.HeaderText = "등록인";
            this.namae.Name = "namae";
            this.namae.ReadOnly = true;
            // 
            // registed_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.drag_lb);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registed_car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registed_car";
            this.Load += new System.EventHandler(this.registed_car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label drag_lb;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bokji_namae;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn regist_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn namae;
    }
}