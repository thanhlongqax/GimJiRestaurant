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

namespace Gimji.GUI.Menu
{
    public partial class uc_MonAnCart : UserControl
    {
        public uc_MonAnCart()
        {
            InitializeComponent();
        }

        private void uc_MonAnCart_Load(object sender, EventArgs e)
        {

        }

        private void pic_image_Click(object sender, EventArgs e)
        {
        }

        #region Properties

        public Guna2PictureBox PicBox
        {
            get { return pic_image; }
            set { pic_image = value; }
        }

        public Label Title
        {
            get { return lb_tenMonAn; }
            set { lb_tenMonAn = value; }
        }
        public Label Price
        {
            get { return lb_price; }
            set { lb_price = value; }
        }

        public Label Count
        {
            get { return lb_count; }
            set { lb_count = value; }
        }

        #endregion
    }
}
