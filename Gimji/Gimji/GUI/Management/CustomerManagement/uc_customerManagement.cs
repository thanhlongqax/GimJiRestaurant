using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Management.CustomerManagement
{
    public partial class uc_customerManagement : UserControl
    {
        public uc_customerManagement()
        {
            InitializeComponent();
        }

        private void uc_customerManagement_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                pal_listCustomer.Controls.Add(new uc_customer());
            }


        }

        #region Properties

        public Guna2TextBox SearchTxt
        {
            get { return txt_search; }
            set { txt_search = value; }
        }
        public Guna2TextBox NameTxt
        {
            get { return txt_name; }
            set { txt_name = value; }
        }
        public Guna2TextBox EmailTxt
        {
            get { return txt_email; }
            set { txt_email = value; }
        }
        public Guna2TextBox AddressTxt
        {
            get { return txt_address; }
            set { txt_address = value; }
        }
        public Guna2TextBox IdTxt
        {
            get { return txt_id; }
            set { txt_id = value; }
        }
        public Guna2TextBox PhoneTxt
        {
            get { return txt_phoneNumber; }
            set { txt_phoneNumber = value; }
        }
        public Guna2DateTimePicker DateTxt
        {
            get { return txt_time; }
            set { txt_time = value; }
        }
        public Guna2TextBox GenderTxt
        {
            get { return txt_gender; }
            set { txt_gender = value; }
        }
        public Guna2TextBox PointTxt
        {
            get { return txt_point; }
            set { txt_point = value; }
        }

        #endregion
    }
}
