using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void guna_btn_edit_Click(object sender, EventArgs e)
        {
            uc_staffManagement uc_StaffManagement = new uc_staffManagement();
            uc_detailInfo uc_DetailInfo = new uc_detailInfo();

            //uc_StaffManagement.Controls.Add();
            
            
        }

        #region Properties

        [Category("Custom Props")]
        public string StaffName
        {
            get { return lb_name.Text; }
            set { lb_name.Text = value; }
        }

        [Category("Custom Props")]
        public string Position
        {
            get { return lb_position.Text; }
            set { lb_position.Text = value; }
        }

        [Category("Custom Props")]
        public string StaffID
        {
            get { return lb_id.Text; }
            set { lb_id.Text = value; }
        }

        [Category("Custom Props")]
        public int Stt
        {
            get { return Convert.ToInt32(lb_stt.Text); }
            set { lb_stt.Text = value.ToString(); }
        }

        #endregion
    }
}
