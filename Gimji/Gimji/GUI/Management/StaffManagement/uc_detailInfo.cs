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
    public partial class uc_detailInfo : UserControl
    {
        public event EventHandler Btn_SaveClick;
        public event EventHandler Btn_CancelClick;
        public event EventHandler Btn_Add_FullNameClick;
        public uc_detailInfo()
        {
            InitializeComponent();
        }
        #region Properties

        public TextBox IdStaffTxt
        {
            get { return txt_IdStaff; }
            set { txt_IdStaff = value; }
        }
        public string Username
        {
            get { return guna_txt_username.Text; }
            set { guna_txt_username.Text = value; }
        }

        public string Password
        {
            get { return guna_txt_password.Text; }
            set { guna_txt_password.Text = value; }
        }
        public TextBox NameTxt
        {
            get { return txt_Name; }
            set { txt_Name = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox EmailTxt
        {
            get { return guna_txt_email; }
            set { guna_txt_email = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox PhoneNumberTxt
        {
            get { return guna_txt_phoneNumber; }
            set { guna_txt_phoneNumber = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox AddressTxt
        {
            get { return guna_txt_address; }
            set { guna_txt_address = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox BirthdayTxt
        {
            get { return guna_txt_birthday; }
            set { guna_txt_birthday = value; }
        }
        public Guna.UI2.WinForms.Guna2TextBox Txt_Gender
        {
            get { return txt_Gender; }
            set { txt_Gender = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox DateStartTxt
        {
            get { return guna_txt_dateStart; }
            set { guna_txt_dateStart = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox SalaryTxt
        {
            get { return guna_txt_salary; }
            set { guna_txt_salary = value; }
        }

        public Guna.UI2.WinForms.Guna2TextBox Txt_Position
        {
            get { return txt_Position; }
            set { txt_Position = value; }
        }


        #endregion


        private void guna_btn_save_Click(object sender, EventArgs e)
        {
            Btn_SaveClick?.Invoke(this, EventArgs.Empty);
        }

        private void guna_btn_cancel_Click(object sender, EventArgs e)
        {
            Btn_CancelClick?.Invoke(this, EventArgs.Empty);
        }

        private void guna_btn_edit_Click(object sender, EventArgs e)
        {
            Btn_Add_FullNameClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
