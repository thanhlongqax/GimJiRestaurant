using Gimji.GUI.Management.SaleManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Management
{
    public partial class uc_SaleManagement : UserControl
    {
        public uc_SaleManagement()
        {
            InitializeComponent();
        }

        private void uc_SaleManagement_Load(object sender, EventArgs e)
        {
            flow_pal_sale.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                flow_pal_sale.Controls.Add(new uc_sale());
            }
        }
    }
}
