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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button_fogotPassword_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_register.Visible = false;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
            panel_register.Visible = true;
        }
    }
}
