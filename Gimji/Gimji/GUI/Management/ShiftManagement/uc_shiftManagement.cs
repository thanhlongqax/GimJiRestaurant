using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Management.ShiftManagement
{
    public partial class uc_shiftManagement : UserControl
    {
        static DateTime currentDate = DateTime.Now;
        private List<Label> labelList = new List<Label>();


        public uc_shiftManagement()
        {
            InitializeComponent();

        }

        private void UpdateDateTime()
        {
            // Calculate the start and end of the current week
            DateTime startOfWeek = currentDate.AddDays(-(int)currentDate.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            // Format the date range
            string dateRange = startOfWeek.ToString("d MMMM yyyy") + " - " + endOfWeek.ToString("d MMMM yyyy");
            lb_time.Text = dateRange;
            DateTime day = startOfWeek;
            
            //add update date into list label
            foreach (Label lable in labelList)
            {
                lable.Text = day.ToString("dd / MM");
                day = day.AddDays(1);
            }
        }
        private void uc_shiftManagement_Load(object sender, EventArgs e)
        {
            Label[] labels = { lb_sunday, lb_monday, lb_tuesday, lb_wednesday, lb_thursday, lb_friday, lb_saturday };
            labelList.AddRange(labels);
            UpdateDateTime();
            for (int i = 0; i < 21; i++)
            {
                flow_pal_shift.Controls.Add(new uc_shift());
            }
        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(-7);
            UpdateDateTime();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(7);
            UpdateDateTime();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            UpdateDateTime();
        }
    }
}
