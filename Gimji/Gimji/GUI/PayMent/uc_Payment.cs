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
            uc_MonAn_Paymentcs uc_MonAn_Paymentcs = new uc_MonAn_Paymentcs();
            fl_panel_ThucDon_Payment.Controls.Add(uc_MonAn_Paymentcs);
        }
    }
}
