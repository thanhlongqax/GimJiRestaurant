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
    public partial class uc_Order : UserControl
    {
        public uc_Order()
        {
            InitializeComponent();
        }

        private void uc_Order_Load(object sender, EventArgs e)
        {
            //fl_pal_Cart.Controls.Clear();
            //fl_pal_Cart.Controls.Add(new uc_MonAnCart());
            flow_pal_list.Controls.Clear();
            flow_pal_list.Controls.Add(new uc_MonAnCart());
            flow_pal_list.Controls.Add(new uc_MonAnCart());
            flow_pal_list.Controls.Add(new uc_MonAnCart());

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_ORDER_Click(object sender, EventArgs e)
        {

        }

        private void panel_Cart_footer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_dinein_Click(object sender, EventArgs e)
        {
        }

        private void btn_goto_Click(object sender, EventArgs e)
        {
        }

        private void btn_delivery_Click(object sender, EventArgs e)
        {
        }

        private void lb_idOrder_Click(object sender, EventArgs e)
        {
        }

        private void picbox_guess_Click(object sender, EventArgs e)
        {
        }

        private void lb_guess_Click(object sender, EventArgs e)
        {
        }

        private void lb_numGuess_Click(object sender, EventArgs e)
        {
        }

        private void lb_numTable_Click(object sender, EventArgs e)
        {
        }

        private void lb_table_Click(object sender, EventArgs e)
        {
        }

        private void picbox_table_Click(object sender, EventArgs e)
        {
        }

        private void flow_pal_list_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pal_note_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna_btn_apply_Click(object sender, EventArgs e)
        {
        }

        private void guna_txt_code_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna_btn_note_Click(object sender, EventArgs e)
        {
        }

        private void guna_txt_note_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna_btn_send_Click(object sender, EventArgs e)
        {
        }

        private void guna_btn_cancel_Click(object sender, EventArgs e)
        {
        }

        private void lb_totalPrice_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void lb_priceDiscount_Click(object sender, EventArgs e)
        {
        }

        private void lb_percent_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lb_subPrice_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        #region Properties

        public Label IdOrder
        {
            get { return lb_idOrder; }
            set { lb_idOrder = value; }
        }
        public Label NumTable
        {
            get { return lb_numGuess; }
            set { lb_numGuess = value; }
        }
        public Label NumGuess
        {
            get { return lb_numTable; }
            set { lb_numTable = value; }
        }

        public Label Percent
        {
            get { return lb_percent; }
            set { lb_percent = value; }
        }

        public Label SubPrice
        {
            get { return lb_subPrice; }
            set { lb_subPrice = value; }
        }
        public Label DiscountPrice
        {
            get { return lb_priceDiscount; }
            set { lb_priceDiscount = value; }
        }
        public Label TotalPrice
        {
            get { return lb_totalPrice; }
            set { lb_totalPrice = value; }
        }



        #endregion
    }
}
