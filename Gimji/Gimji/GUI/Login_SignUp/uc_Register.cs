using Gimji.BLL;
using Gimji.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Login_SignUp
{
    public partial class uc_Register : UserControl
    {
        public event EventHandler RegistrationSuccess;
        public uc_Register()
        {
            InitializeComponent();
        }

        private void button_register_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_username_register.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_createpass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_confirmpass.Text))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_createpass.Text != textBox_confirmpass.Text)
            {
                MessageBox.Show("Mật Khẩu Không Trùng Khớp Vui Lòng Nhập Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_createpass.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất 8 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Customer customer = new Customer();
                SignUp_BLL signUp_BLL = new SignUp_BLL();
                customer.userName = textBox_username_register.Text;
                customer.userPassword = textBox_createpass.Text;
                signUp_BLL.signUp_BLL(customer);
                OnRegistrationSuccess();
            }
        }
        private void OnRegistrationSuccess()
        {
            RegistrationSuccess?.Invoke(this, EventArgs.Empty);
        }
    }
}
