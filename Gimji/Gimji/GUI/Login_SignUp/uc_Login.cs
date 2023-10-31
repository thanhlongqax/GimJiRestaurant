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
            //AdminUserBLL ehe = new AdminUserBLL();
            tk.userName = txt_username.Text;
            tk.userPassword = txt_password.Text;

            LoginBLL tkBLL = new LoginBLL();

            tkBLL.checkLoginData_Login_BLL(tk);

            /*
            {
                if (ehe.getIdByUsername(tk.userName).ToString().Contains('A'))
                {
                    MainAdmin newMain = new MainAdmin(ehe.getIdByUsername(tk.userName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                else if (ehe.getIdByUsername(tk.userName).ToString().Contains('U'))
                {
                    MainUser newMain = new MainUser(ehe.getIdByUsername(tk.userName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                else if (ehe.getIdByUsername(tk.userName).ToString().Contains('S'))
                {
                    MainStaff newMain = new MainStaff(ehe.getIdByUsername(tk.userName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                else if (ehe.getIdByUsername(tk.userName).ToString().Contains('M'))
                {
                    MainManager newMain = new MainManager(ehe.getIdByUsername(tk.userName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                return;
            }*/
        }
    }
}
