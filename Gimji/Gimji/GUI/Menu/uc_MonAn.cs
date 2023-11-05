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
            get { return guna_pic_image; }
            set { guna_pic_image = value; }
        }

        public Label Title
        {
            get { return lb_name; }
            set { lb_name = value; }
        }
        public Label Price
        {
            get { return lb_price; }
            set { lb_price = value; }
        }

        #endregion


    }
}
