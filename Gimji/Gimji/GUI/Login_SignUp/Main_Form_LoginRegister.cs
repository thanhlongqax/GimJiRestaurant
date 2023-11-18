using Gimji.GUI.Login_SignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji
{
    public partial class Main_Form_LoginRegister : Form
    {
        private uc_Login loginControl;
        private uc_Register registerControl;
        private bool registeredSuccessfully = false;

        public Main_Form_LoginRegister()
        {
            InitializeComponent();

            // Khởi tạo các thành phần giao diện
            loginControl = new uc_Login();
            registerControl = new uc_Register();

            // Đăng ký xử lý sự kiện RegistrationSuccess
            registerControl.RegistrationSuccess += (sender, e) => RegisteredSuccessfully();

            // Hiển thị màn hình đăng nhập ban đầu
            ShowLoginScreen();
        }

        private void RegisteredSuccessfully()
        {
            registeredSuccessfully = true;
            ShowLoginScreen();
        }
        // Hiển thị màn hình đăng nhập
        private void ShowLoginScreen()
        {
            panel_Login_Register.Controls.Clear();
            panel_Login_Register.Controls.Add(loginControl);
            
            if (registeredSuccessfully)
            {
                // Thực hiện các xử lý sau khi đăng ký thành công (nếu cần)
                registeredSuccessfully = false; // Đặt lại cờ
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // Hiển thị màn hình đăng nhập
            ShowLoginScreen();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            // Hiển thị màn hình đăng ký
            panel_Login_Register.Controls.Clear();
            panel_Login_Register.Controls.Add(registerControl);
        }
    }

}
