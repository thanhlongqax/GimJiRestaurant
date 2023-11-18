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
    public partial class uc_Order : UserControl
    {
        public uc_Order()
        {
            InitializeComponent();
        }

        private void uc_Order_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                pal_listReport.Controls.Add(new uc_orderList());
            }
        }
    }
}
