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
using Gimji.GUI.Management;

namespace Gimji.GUI.Management.StaffManagement
{
    public partial class uc_staffManagement : UserControl
    {
        uc_detailInfo dt = new uc_detailInfo();

        CRUD_Staff_BLL newBLL = new CRUD_Staff_BLL();
        public uc_staffManagement()
        {
            InitializeComponent();
        }

        private void uc_staffManagement_Load(object sender, EventArgs e)
        {
            uc_detailInfo uc_DetailInfo = new uc_detailInfo();
            List<Staff> staffList = new List<Staff>();
            staffList = newBLL.getAllStaff();
            int stt = 0;
            foreach (var staff in staffList)
            {
                uc_staff uc_Staff = new uc_staff();
                uc_Staff.Stt = stt++; 
                uc_Staff.StaffID = staff.Id;
                uc_Staff.StaffName = staff.fullName;
                uc_Staff.Position = staff.position;
                flow_pal_listStaff.Controls.Add(uc_Staff);

                uc_Staff.GunaButtonEditClick += (s, eventArgs) =>
                {
                    Staff staff = new Staff();
                    staff = newBLL.getStaffbyId(uc_Staff.StaffID);
                    uc_DetailInfo.IdStaffTxt.Text = staff.Id;
                    uc_DetailInfo.NameTxt.Text = staff.userName;
                    uc_DetailInfo.EmailTxt.Text = staff.Email;
                    uc_DetailInfo.PhoneNumberTxt.Text = staff.phoneNumber;
                    uc_DetailInfo.AddressTxt.Text = staff.contactAddress;
                    uc_DetailInfo.BirthdayTxt.Text = staff.DateOfBirth;
                    List<string> Gender = new List<string>
                    {
                        staff.Gender
                    };
                    uc_DetailInfo.GenderCboBox.DataSource = Gender;
                    uc_DetailInfo.DateStartTxt.Text = staff.dateStart;
                    uc_DetailInfo.SalaryTxt.Text = staff.Salary;
                    List<string> position = new List<string>
                    {
                        staff.position
                    };
                    uc_DetailInfo.PositionCboBox.DataSource = position;
                    uc_DetailInfo.Username = staff.userName;
                    uc_DetailInfo.Password = staff.userPassword;
                    guna_panel_detailInfor.Controls.Add(uc_DetailInfo);

                };

            }

        }

        private void guna_btn_create_Click(object sender, EventArgs e)
        {

        }
    }
}
