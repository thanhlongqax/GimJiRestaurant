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

namespace Gimji.GUI.Management.ProductManagement
{
    public partial class uc_product : UserControl
    {
        public uc_product()
        {
            InitializeComponent();
        }

        #region Properties
        public Guna2CirclePictureBox pictureBox
        {
            get { return pic_image; }
            set { pic_image = value; }
        }
        public TextBox NameTxt
        {
            get { return txt_name; }
            set { txt_name = value; }
        }
        public TextBox PriceTxt
        {
            get { return txt_price; } 
            set { txt_price = value; }
        }

        #endregion
    }
}
