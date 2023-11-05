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

        public uc_staffManagement()
        {
            InitializeComponent();
        }

        private void uc_staffManagement_Load(object sender, EventArgs e)
        {
            flow_pal_listStaff.Controls.Clear();
            LoadStaff();
        }

        private void LoadStaff()
        {
            uc_detailInfo uc_DetailInfo = new uc_detailInfo();
            List<Staff> staffList = new List<Staff>();
            CRUD_Staff_BLL newBLL = new CRUD_Staff_BLL();
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
                    uc_DetailInfo.Txt_Gender.Text = staff.Gender;
                    uc_DetailInfo.DateStartTxt.Text = staff.dateStart;
                    uc_DetailInfo.SalaryTxt.Text = staff.Salary;
                    uc_DetailInfo.Txt_Position.Text = staff.position;
                    uc_DetailInfo.Username = staff.userName;
                    uc_DetailInfo.Password = staff.userPassword;
                    guna_panel_detailInfor.Controls.Clear();
                    guna_panel_detailInfor.Controls.Add(uc_DetailInfo);
                };

                uc_Staff.GunaButtonDeleteClick += (s, eventArgs) =>
                {
                    newBLL.deletebyId(uc_Staff.StaffID);
                };
            }

        }

        private void guna_btn_create_Click(object sender, EventArgs e)
        {
            //uc_Staff.GunaButtonEditClick += (s, eventArgs) =>

            uc_detailInfo newDetail = new uc_detailInfo();
            Staff newStaff = new Staff();
            CRUD_Staff_BLL newBLL = new CRUD_Staff_BLL();
            guna_panel_detailInfor.Controls.Add(newDetail);
            newDetail.Btn_SaveClick += (s, eventArgs) =>
            {
                newStaff.userName = newDetail.Username;
                newStaff.userPassword = newDetail.Password;
                newStaff.fullName = newDetail.NameTxt.Text;
                newStaff.DateOfBirth = newDetail.BirthdayTxt.Text;
                newStaff.Gender = newDetail.Txt_Gender.Text;
                newStaff.contactAddress = newDetail.AddressTxt.Text;
                newStaff.phoneNumber = newDetail.PhoneNumberTxt.Text;
                newStaff.Email = newDetail.EmailTxt.Text;
                newStaff.dateStart = newDetail.DateStartTxt.Text;
                newStaff.Salary = newDetail.SalaryTxt.Text;
                newStaff.position = newDetail.Txt_Position.Text;
                newBLL.updateStaff(newStaff);
                guna_panel_detailInfor.Controls.Add(newDetail);
                LoadStaff();
            };
            newDetail.Btn_CancelClick += (s, eventArgs) =>
            {
                guna_panel_detailInfor.Controls.Clear();
                guna_panel_detailInfor.Controls.Add(newDetail);
            };

        }
    }
}
