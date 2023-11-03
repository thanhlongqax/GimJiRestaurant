using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gimji.BLL;
using Gimji.DTO;

namespace Gimji.GUI.Management.StaffManagement
{
    public partial class uc_staffManagement : UserControl
    {


        CRUD_Staff_BLL newBLL = new CRUD_Staff_BLL();
        public uc_staffManagement()
        {
            InitializeComponent();
        }

        private void uc_staffManagement_Load(object sender, EventArgs e)
        {
            uc_detailInfo uc_DetailInfo = new uc_detailInfo();
            guna_panel_detailInfor.Controls.Add(uc_DetailInfo);
            List<Staff> staffList = new List<Staff>();
            staffList = newBLL.getAllStaff();
            int stt = 0;
            foreach (var staff in staffList)
            {
                uc_staff uc_Staff = new uc_staff(); // Create a new instance of your UserControl
                uc_Staff.Stt = stt++; // Assign a unique status counter
                uc_Staff.StaffID = staff.Id;
                uc_Staff.StaffName = staff.fullName;
                uc_Staff.Position = staff.position; // You can set the position based on your data
                flow_pal_listStaff.Controls.Add(uc_Staff);
            }

        }

        private void guna_btn_create_Click(object sender, EventArgs e)
        {

        }
    }
}
