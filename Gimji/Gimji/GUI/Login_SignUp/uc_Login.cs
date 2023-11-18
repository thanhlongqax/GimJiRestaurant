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

namespace Gimji.GUI.Login_SignUp
{
    public partial class uc_Login : UserControl
    {
        public uc_Login()
        {
            InitializeComponent();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Customer tk = new Customer();
            tk.userName = txt_username.Text;
            tk.Password = txt_password.Text;
            LoginBLL tkBLL = new LoginBLL();

            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string id = tkBLL.checkLoginData_Login_BLL(tk);
            if(id != null)
            {
                Stored_Login_Infor.StorageUser(id);
                this.ParentForm.Hide();
                mainForm mainForm = new mainForm();
                mainForm.ShowDialog();
                this.ParentForm.Show();
            }

        }
    }
}
