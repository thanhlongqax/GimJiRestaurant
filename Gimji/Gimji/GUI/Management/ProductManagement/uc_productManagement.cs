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
using Gimji.GUI.Management.CustomerManagement;
using Gimji.GUI.Management.StaffManagement;
using Gimji.Properties;
using Guna.UI2.WinForms.Suite;

namespace Gimji.GUI.Management.ProductManagement
{
    public partial class uc_productManagement : UserControl
    {
        String url_HinhAnh = null;
        int Id = 0;
        uc_product uc_Product = null;
        private uc_product selectedProduct; // Biến toàn cục để lưu trữ uc_Staff được chọn
        public uc_productManagement()
        {
            InitializeComponent();
        }
        private void uc_productManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                url_HinhAnh = openFile.FileName;

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            pal_inforDish.Visible = true;
        }
        private void LoadData()
        {
            pal_inforDish.Visible = false;
            flow_pal_listProduct_Clear();
            List<Dish> listDish = new List<Dish>();
            CRUD_Dish_BLL newBLL = new CRUD_Dish_BLL();
            String DishID = null;
            listDish = newBLL.getAllDish();
            foreach (var Dish in listDish)
            {
                uc_product uc_Product = new uc_product();
                try
                {
                    uc_Product.PictureBox = Image.FromFile(Dish.DishPicture);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khi không thể tải hình ảnh.
                    // Ví dụ: Hiển thị hình ảnh mặc định hoặc thông báo lỗi.
                    uc_Product.PictureBox = Image.FromFile("Resources/AnhMonAn/Tokbokki/tokbokki_chả_cá_sốt_HQ-removebg-preview.png"); // Thay "default_image.jpg" bằng hình ảnh mặc định của bạn.
                                                                                                                                           // Hoặc hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi Đường Dẫn: " + ex.Message);
                }
                uc_Product.ID = Dish.DishId;
                uc_Product.NameTxt = Dish.DishName;
                uc_Product.PriceTxt = Dish.DishPrice;

                // Đăng ký sự kiện BtnEditClick cho mỗi uc_staff
                uc_Product.BtnEditClick += (s, eventArgs) =>
                {
                    // Lưu trữ uc_product được chọn vào biến toàn cục
                    selectedProduct = (uc_product)s;
                    HandleBtnEditClick((uc_product)s, Dish);

                };
                uc_Product.BtnRemoveClick += (s, eventArgs) =>
                {
                    // Lưu trữ uc_product được chọn vào biến toàn cục
                    selectedProduct = (uc_product)s;
                    btn_delete_Click(s, eventArgs);

                };
                flow_pal_listProduct.Controls.Add(uc_Product);
            }
        }
        private void flow_pal_listProduct_Clear()
        {
            foreach (Control control in flow_pal_listProduct.Controls)
            {
                if (control is uc_product)
                {
                    // Loại bỏ tất cả các uc_Product
                    flow_pal_listProduct.Controls.Remove(control);
                }
            }
        }
        private void HandleBtnEditClick(uc_product uc_Product, Dish dish)
        {
            pal_inforDish.Visible = true;
            selectedProduct = uc_Product;
            Id = uc_Product.ID;
            txt_Name.Text = uc_Product.NameTxt;
            txt_Price.Text = uc_Product.PriceTxt.ToString();

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                // Lấy thông tin nhân viên từ selectedStaff
                // Thực hiện xóa product dựa trên idProduct
                int idProduct = selectedProduct.ID;

                if (idProduct != 0)
                {
                    CRUD_Dish_BLL newBLL = new CRUD_Dish_BLL();
                    newBLL.DeleteDishById(idProduct);
                    // Sau khi xóa, bạn có thể làm gì đó, ví dụ: cập nhật giao diện
                    LoadData();
                }
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pal_inforDish.Visible = false;
            txt_Name.Text = string.Empty;
            txt_Price.Text = string.Empty;
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Dish dish = new Dish();
            CRUD_Dish_BLL newBLL = new CRUD_Dish_BLL();
            dish.DishId = Id;
            dish.DishName = txt_Name.Text;
            dish.DishPrice = Convert.ToDouble(txt_Price.Text);
            dish.DishPicture = url_HinhAnh;
            dish.Catergory_Id = ?
        }
        private void btn_Tokbokki_Click(object sender, EventArgs e)
        {

        }

        private void btn_Kimbak_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rice_Click(object sender, EventArgs e)
        {

        }

        private void btn_Meat_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salad_Click(object sender, EventArgs e)
        {

        }


    }
}
