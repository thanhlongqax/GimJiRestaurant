using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Management.StaffManagement
{
    public partial class uc_staff : UserControl
    {
        public uc_staff()
        {
            InitializeComponent();
        }

        private void guna_pal_staff_MouseEnter(object sender, EventArgs e)
        {
            guna_pal_staff.FillColor = Color.FromArgb(119, 24, 24);
        }

        private void guna_pal_staff_MouseLeave(object sender, EventArgs e)
        {
            guna_pal_staff.FillColor = Color.Transparent;
        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }
    }
}
