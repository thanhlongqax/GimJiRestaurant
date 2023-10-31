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
            //panel_Order.Controls.Add(new uc_Order());
            //fl_Panel_Thuc_Don.Controls.Add(new uc_MonAn());
        }

        private void btn_Tokbokki_Click(object sender, EventArgs e)
        {
            uc_MonAn Tokbokki = new uc_MonAn();
            Tokbokki.setMonAn("asdf", "asdfsd", @"Resources/AnhMonAn/Tokbokki/Tokbokki_sotPhoMai");
            Tokbokki.Controls.Clear();
            fl_Panel_Thuc_Don.Controls.Add(Tokbokki);

        }

        private void btn_KimBak_Click(object sender, EventArgs e)
        {

        }

        private void btn_Com_Tron_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thit_Nuong_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salad_Click(object sender, EventArgs e)
        {

        }
    }
}
