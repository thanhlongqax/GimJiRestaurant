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
        public Main_Form_LoginRegister()
        {
            InitializeComponent();
            uc_Login Login = new uc_Login();
            panel_Login_Register.Controls.Add(Login);


        }

        private void button_fogotPassword_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            uc_Login Login = new uc_Login();
            panel_Login_Register.Controls.Clear();
            panel_Login_Register.Controls.Add(Login);
            //panel_Login_Register

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            panel_Login_Register.Controls.Clear();
            uc_Register Register = new uc_Register();
            panel_Login_Register.Controls.Add(Register);
        }
    }
}
