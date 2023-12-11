using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Order
{
    public partial class uc_orderList : UserControl
    {
        public event EventHandler BtnDeleteClick;
        public event EventHandler BtEditClick;
        int quantity;
        private int idProduct;
        private int idCategory;
        public uc_orderList()
        {
            InitializeComponent();
        }

        private void btn_edit_Staff_Click(object sender, EventArgs e)
        {
            BtEditClick?.Invoke(this, e);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            BtnDeleteClick?.Invoke(this, e);
        }
        #region Properties
        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }
        public string IdStaff
        {
            get { return lb_id.Text; }
            set { lb_id.Text = value; }
        }
        public int IdCategory
        {
            get { return idCategory; }
            set { idCategory = value; }
        }

        public String nameCustomer
        {
            get { return lb_customer.Text; }
            set { lb_customer.Text = value; }
        }
        public String startDate
        {
            get { return lb_date.Text; }
            set { lb_date.Text = value; }
        }
        public double Price
        {
            get { return Convert.ToDouble(lb_total.Text); }
            set { lb_total.Text = value.ToString(); }
        }

        public String Status
        {
            get { return lb_Status.Text; }
            set
            {
                lb_Status.Text = value;
            }
        }
        #endregion
    }
}
