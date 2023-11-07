using Gimji.BLL;
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
        uc_MonAn Tokbokki = new uc_MonAn();
        public uc_Menu()
        {
            InitializeComponent();
        }

        private void uc_Menu_Load(object sender, EventArgs e)
        {
            flow_pal_List.Controls.Add(new uc_MonAnCart());

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
