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
        public uc_Payment()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                flow_pal_listOrder.Controls.Add(new uc_MonAn_Paymentcs());
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
