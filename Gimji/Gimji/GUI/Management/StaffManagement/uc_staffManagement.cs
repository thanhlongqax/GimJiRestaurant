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
    public partial class uc_staffManagement : UserControl
    {
        public uc_staffManagement()
        {
            InitializeComponent();
        }

        private void uc_staffManagement_Load(object sender, EventArgs e)
        {
            uc_staff uc_Staff = new uc_staff();
            uc_detailInfo uc_DetailInfo = new uc_detailInfo();
            flow_pal_listStaff.Controls.Add(uc_Staff);
            guna_panel_detailInfor.Controls.Add(uc_DetailInfo);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
