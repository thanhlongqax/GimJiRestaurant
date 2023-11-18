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

namespace Gimji.GUI.Login_Register
{
    public partial class Main_Login_Register : Form
    {
        public Main_Login_Register()
        {
            InitializeComponent();
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            setColorButton(btn_Login, btn_Register);
            pal_form.Controls.Clear();
            pal_form.Controls.Add(new uc_Login());
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            setColorButton(btn_Register, btn_Login);
            pal_form.Controls.Clear();
            pal_form.Controls.Add(new uc_Register());
        }

        private void setColorButton(Guna2Button btnStart, Guna2Button btnEnd)
        {
            btnStart.FillColor = Color.FromArgb(151, 118, 68);
            btnStart.ForeColor = Color.White;
            btnEnd.FillColor = Color.Transparent;
            btnEnd.ForeColor = Color.FromArgb(143, 125, 97);
        }

        private void Main_Login_Register_Load(object sender, EventArgs e)
        {
            setColorButton(btn_Login, btn_Register);
            pal_form.Controls.Clear();
            pal_form.Controls.Add(new uc_Login());
        }
    }
}
