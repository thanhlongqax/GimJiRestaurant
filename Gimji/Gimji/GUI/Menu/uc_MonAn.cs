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
    public partial class uc_MonAn : UserControl
    {
        public uc_MonAn()
        {
            InitializeComponent();
        }
        public void setMonAn(String tenMonAn, String giaTien, String hinhAnh)
        {
            //    txt_TenMonAn.Text = tenMonAn;
            //    txt_GiaTien.Text = giaTien;
            //    if (System.IO.File.Exists(hinhAnh))
            //    {
            //        pictureBox_hinhAnh.BackgroundImage = Image.FromFile(hinhAnh);
            //    }
            //    else
            //    {
            //        // Xử lý trường hợp tệp hình ảnh không tồn tại
            //        // Ví dụ: Hiển thị một hình ảnh mặc định hoặc thông báo lỗi.
            //        pictureBox_hinhAnh.Image = null; // Gán hình ảnh mặc định hoặc null
            //    }
        }

        #region Properties

        public Guna2CirclePictureBox PicBox
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

        #endregion


    }
}
