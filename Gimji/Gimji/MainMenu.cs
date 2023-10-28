using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Gimji.DAO;
using Gimji.DTO;
using Gimji.GUI.Menu;

namespace Gimji
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void pictureBox_logout_Click(object sender, EventArgs e)
        {

            DatabaseAccess dal = new DatabaseAccess();

            MessageBox.Show(dal.getIdByUsername_DAL("thanhlong"));


        }

        private void pictureBox_menu_MouseHover(object sender, EventArgs e)
        {
            //pictureBox_menu.BackgroundImage = Color.FromArgb(209, 10, 45);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btn_Home.BackColor = Color.White;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            fl_Panel_Thuc_Don.Controls.Add(new uc_MonAn());
        }
    }
}