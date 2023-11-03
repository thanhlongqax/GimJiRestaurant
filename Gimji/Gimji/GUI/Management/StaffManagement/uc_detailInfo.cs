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
        public uc_detailInfo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna_txt_phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
        #region Properties

        public TextBox IdStaffTxt
        {
            get { return txt_IdStaff; }
            set { txt_IdStaff = value; }
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

        public PictureBox PictureBox
        {
            get { return pictureBox1; }
            set { pictureBox1 = value; }
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

        public Guna.UI2.WinForms.Guna2ComboBox GenderCboBox
        {
            get { return guna_combo_gender; }
            set { guna_combo_gender = value; }
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

        public Guna.UI2.WinForms.Guna2ComboBox PositionCboBox
        {
            get { return guna_combo_position; }
            set { guna_combo_position = value; }
        }

        #endregion


    }
}
