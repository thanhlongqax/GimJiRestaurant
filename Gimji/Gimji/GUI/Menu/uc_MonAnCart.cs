using Guna.UI2.WinForms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Menu
{
    public partial class uc_MonAnCart : UserControl
    {
        int quantity = 0;
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

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            quantity++;
            // Cập nhật hiển thị số lượng trên Label hoặc TextBox
            txt_Quanity.Text = quantity.ToString();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                quantity--;
                // Cập nhật hiển thị số lượng trên Label hoặc TextBox
                txt_Quanity.Text = quantity.ToString();
            }
        }


    #region Properties

    public Guna2PictureBox PicBox
        {
            get { return pic_DishPicture; }
            set { pic_DishPicture = value; }
        }

        public Label Title
        {
            get { return txt_DishName; }
            set { txt_DishName = value; }
        }
        public Label Price
        {
            get { return txt_DishPrice; }
            set { txt_DishPrice = value; }
        }

        public Label Count
        {
            get { return txt_Quanity; }
            set { txt_Quanity = value; }
        }

        #endregion
    }
}
