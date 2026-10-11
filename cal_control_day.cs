using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace portfolio
{
    public partial class cal_control_day : UserControl
    {
        private ToolTip toolTip;

        public cal_control_day()
        {
            InitializeComponent();
            toolTip = new ToolTip();
            lb_commute.Visible = false;
        }

        public void day(int numday)
        {
            lb_day.Text = numday.ToString();
        }

        public void SetSaturday(bool isSaturday)
        {
            if (isSaturday)
            {
                lb_day.ForeColor = Color.Blue;
            }
        }

        public void SetSunday(bool isSunday)
        {
            if (isSunday)
            {
                lb_day.ForeColor = Color.Red;
            }
        }

        public void SetHoliday(string text, bool isSaturday)
        {
            lb_day.ForeColor = Color.Red;
            toolTip.SetToolTip(this, text);
            if (isSaturday)
            {
                lb_day.ForeColor = Color.Blue;
            }
        }

        public void SetCommute(List<string> commutes)
        {
            if (commutes != null && commutes.Count > 0)
            {
                lb_commute.Visible = true;
                lb_commute.Text = string.Join(Environment.NewLine, commutes);
                toolTip.SetToolTip(lb_commute, lb_commute.Text);
            }
            
        }
    }
}