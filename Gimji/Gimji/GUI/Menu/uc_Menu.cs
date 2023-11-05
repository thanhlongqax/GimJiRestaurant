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
        uc_Order uc_Order = new uc_Order();
        public uc_Menu()
        {
            InitializeComponent();
        }

        private void uc_Menu_Load(object sender, EventArgs e)
        {
            //panel_Order.Controls.Add(new uc_Order());
            //fl_Panel_Thuc_Don.Controls.Add(new uc_MonAn());
            //fl_Panel_Thuc_Don.Controls.Add(Tokbokki);
            pal_Order.Controls.Add(uc_Order);
            //fl_Panel_Thuc_Don.Controls.Clear();
            //Tokbokki.setMonAn("Tokbokki Pho Mai", "50000VND", @"Resources/AnhMonAn/Tokbokki/tokbokki_gà_sốt_HQ-removebg-preview.png");
            //, @"Resources/AnhMonAn/Tokbokki/Tokbokki_sotPhoMai"

            //fl_Panel_Thuc_Don.Controls.Add(Tokbokki);

        }

        private void guna_btn_tokbo_Click(object sender, EventArgs e)
        {

            // uc_MonAn a = new uc_MonAn();
            //a.setMonAn("Tokbokki Pho Mai", "50000VND", @"Resources/AnhMonAn/Tokbokki/tokbokki_gà_sốt_HQ-removebg-preview.png");
            ////, @"Resources/AnhMonAn/Tokbokki/Tokbokki_sotPhoMai"
            //fl_Panel_Thuc_Don.Controls.Clear();
            //Tokbokki.setMonAn("Tokbokki Pho Mai", "50000VND", @"Resources/AnhMonAn/Tokbokki/tokbokki_gà_sốt_HQ-removebg-preview.png");
            ////, @"Resources/AnhMonAn/Tokbokki/Tokbokki_sotPhoMai"

            //fl_Panel_Thuc_Don.Controls.Add(Tokbokki);
            for (int i = 0; i < 5; i++)
            {
                fl_Panel_Thuc_Don.Controls.Add(new uc_MonAn());
            }


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

        private void pal_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna_btn_kimbab_Click(object sender, EventArgs e)
        {

        }


    }
}
