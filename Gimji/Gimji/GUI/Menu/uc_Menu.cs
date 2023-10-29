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
    public partial class uc_Menu : UserControl
    {
        public uc_Menu()
        {
            InitializeComponent();
        }

        private void uc_Menu_Load(object sender, EventArgs e)
        {
            panel_Header.Controls.Add(new uc_Header());
            panel_Order.Controls.Add(new uc_Order());
            fl_Panel_Thuc_Don.Controls.Add(new uc_MonAn());
        }
    }
}
