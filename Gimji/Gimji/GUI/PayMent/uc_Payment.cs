using Gimji.DTO;
using Gimji.GUI.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.PayMent
{
    public partial class uc_Payment : UserControl
    {
        int IdCategory = 0;
        private uc_MonAn_Paymentcs selectedMonAn; // Biến toàn cục để lưu trữ uc_MonAn được chọn
        private List<CartItem> listCartItems;
        public uc_Payment()
        {
            InitializeComponent();

        }
        private void uc_Payment_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            flow_pal_listOrder_Clear();
            string currentUser = Stored_Login_Infor.GetCurrentUser();
            if (currentUser != null)
            {
                lbl_idOrder.Text = currentUser;
            }

            lb_time.Text = DateTime.Now.ToString();
            List<CartItem> cartItems = CartItemManager.GetCartItems();
            foreach (CartItem cartItem in cartItems)
            {
                uc_MonAn_Paymentcs MonAn_Paymentcs = new uc_MonAn_Paymentcs();
                MonAn_Paymentcs.ID = cartItem.Id;
                MonAn_Paymentcs.IdCategory = cartItem.Catergory_Id;
                MonAn_Paymentcs.Name = cartItem.Name;
                MonAn_Paymentcs.Price = cartItem.Price;
                cartItem.Quantity = cartItem.Quantity;
                try
                {
                    MonAn_Paymentcs.PictureBox = Image.FromFile(cartItem.DishPicture);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khi không thể tải hình ảnh.
                    // Ví dụ: Hiển thị hình ảnh mặc định hoặc thông báo lỗi.
                    MonAn_Paymentcs.PictureBox = Image.FromFile("Resources/AnhMonAn/Default.jpg");
                    // Thay "default_image.jpg" bằng hình ảnh mặc định của bạn.                                                                                                  // Hoặc hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi Đường Dẫn: " + ex.Message);
                }
                MonAn_Paymentcs.BtnDeleteClick += (s, eventArgs) =>
                {
                    selectedMonAn = (uc_MonAn_Paymentcs)s;
                    // btn_delete_Click(s, eventArgs);
                };
                flow_pal_listOrder.Controls.Add(MonAn_Paymentcs);

            }


        }
        private void flow_pal_listOrder_Clear()
        {
            if (flow_pal_listOrder != null)
            {
                List<Control> controlsToRemove = new List<Control>();

                foreach (Control control in flow_pal_listOrder.Controls)
                {
                    if (control is uc_MonAn_Paymentcs)
                    {
                        // Thêm các uc_Product cần xóa vào danh sách tạm thời
                        controlsToRemove.Add(control);
                    }
                }
                // Xóa tất cả các uc_Product từ danh sách tạm thời
                foreach (Control controlToRemove in controlsToRemove)
                {
                    flow_pal_listOrder.Controls.Remove(controlToRemove);

                }
            }

        }

        private void btn_qrCode_Click(object sender, EventArgs e)
        {
            pal_payment.Controls.Clear();
            pal_payment.Controls.Add(new uc_qrCode());
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            pal_payment.Controls.Clear();

        }

        private void btn_creditCard_Click(object sender, EventArgs e)
        {
            pal_payment.Controls.Clear();
            pal_payment.Controls.Add(new uc_credirCard());
        }


    }
}
