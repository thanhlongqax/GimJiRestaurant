using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Gimji.DAO;
using Gimji.DTO;
using Gimji.GUI.Home;
using Gimji.GUI.Menu;
using Gimji.GUI.PayMent;

namespace Gimji
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            date_time.Text = DateTime.Now.ToLongDateString();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            //fl_Panel_Thuc_Don.Controls.Add(new uc_MonAn());
            //panel_Order.Controls.Add(new uc_Order());
            uc_Menu uc_Menu = new uc_Menu();
            panel_Menu.Controls.Clear();
            panel_Menu.Controls.Add(uc_Menu);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            uc_Payment payment = new uc_Payment();
            panel_Menu.Controls.Clear();
            panel_Menu.Controls.Add(payment);
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            uc_Home home = new uc_Home();
            panel_Menu.Controls.Clear();
            panel_Menu.Controls.Add(home);
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {

        }

        private void date_time_Click(object sender, EventArgs e)
        {

        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}