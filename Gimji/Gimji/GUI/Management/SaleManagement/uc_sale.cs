using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Management.SaleManagement
{
    public partial class uc_sale : UserControl
    {
        public uc_sale()
        {
            InitializeComponent();
        }

        private void pal_sale_MouseEnter(object sender, EventArgs e)
        {
            pal_sale.FillColor = Color.FromArgb(119, 24, 24);
        }

        private void pal_sale_MouseLeave(object sender, EventArgs e)
        {
            pal_sale.FillColor = Color.Transparent;
        }
    }
}
