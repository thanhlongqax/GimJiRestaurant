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
            txt_tenMonAn.Text = tenMonAn;
            txt_giaTien.Text = giaTien;
            txt_giaTien.BackColor = System.Drawing.Color.Black;
            if (System.IO.File.Exists(hinhAnh))
            {
                pictureBox_hinhMonAn.BackgroundImage = Image.FromFile(hinhAnh);
            }
            else
            {
                // Xử lý trường hợp tệp hình ảnh không tồn tại
                // Ví dụ: Hiển thị một hình ảnh mặc định hoặc thông báo lỗi.
                pictureBox_hinhMonAn.Image = null; // Gán hình ảnh mặc định hoặc null
            }
        }
    }
}
