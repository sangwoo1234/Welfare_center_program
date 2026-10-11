namespace portfolio
{
    partial class cal_control_day
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_day = new System.Windows.Forms.Label();
            this.lb_commute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_day
            // 
            this.lb_day.AutoSize = true;
            this.lb_day.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_day.ForeColor = System.Drawing.Color.Black;
            this.lb_day.Location = new System.Drawing.Point(14, 13);
            this.lb_day.Name = "lb_day";
            this.lb_day.Size = new System.Drawing.Size(25, 19);
            this.lb_day.TabIndex = 0;
            this.lb_day.Text = "00";
            // 
            // lb_commute
            // 
            this.lb_commute.AutoSize = true;
            this.lb_commute.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lb_commute.ForeColor = System.Drawing.Color.Black;
            this.lb_commute.Location = new System.Drawing.Point(7, 42);
            this.lb_commute.Name = "lb_commute";
            this.lb_commute.Size = new System.Drawing.Size(55, 22);
            this.lb_commute.TabIndex = 0;
            this.lb_commute.Text = "출퇴근";
            // 
            // cal_control_day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_commute);
            this.Controls.Add(this.lb_day);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "cal_control_day";
            this.Size = new System.Drawing.Size(147, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_day;
        private System.Windows.Forms.Label lb_commute;
    }
}
