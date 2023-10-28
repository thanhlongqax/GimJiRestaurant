using System.Drawing.Drawing2D;
using Gimji.DAO;
using Gimji.DTO;
namespace Gimji
{
    public partial class mainUser : Form
    {
        public mainUser()
        {
            InitializeComponent();
        }

        private void pictureBox_logout_Click(object sender, EventArgs e)
        {

            DatabaseAccess dal = new DatabaseAccess();

            MessageBox.Show(dal.getIdByUsername_DAL("thanhlong"));
        }
    }
}