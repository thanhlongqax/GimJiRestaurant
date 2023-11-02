namespace Gimji.GUI.Menu
{
    partial class uc_Menu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Header = new Panel();
            btn_Tokbokki = new Button();
            btn_Salad = new Button();
            btn_KimBak = new Button();
            btn_Com_Tron = new Button();
            btn_Thit_Nuong = new Button();
            fl_Panel_Thuc_Don = new FlowLayoutPanel();
            pal_Order = new Panel();
            panel_Header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Header
            // 
            panel_Header.BorderStyle = BorderStyle.Fixed3D;
            panel_Header.Controls.Add(btn_Tokbokki);
            panel_Header.Controls.Add(btn_Salad);
            panel_Header.Controls.Add(btn_KimBak);
            panel_Header.Controls.Add(btn_Com_Tron);
            panel_Header.Controls.Add(btn_Thit_Nuong);
            panel_Header.Location = new Point(3, 6);
            panel_Header.Margin = new Padding(3, 4, 3, 4);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(940, 81);
            panel_Header.TabIndex = 8;
            // 
            // btn_Tokbokki
            // 
            btn_Tokbokki.Location = new Point(21, 14);
            btn_Tokbokki.Margin = new Padding(3, 4, 3, 4);
            btn_Tokbokki.Name = "btn_Tokbokki";
            btn_Tokbokki.Size = new Size(115, 49);
            btn_Tokbokki.TabIndex = 1;
            btn_Tokbokki.Text = "TOKBOKKI";
            btn_Tokbokki.UseVisualStyleBackColor = true;
            btn_Tokbokki.Click += btn_Tokbokki_Click;
            // 
            // btn_Salad
            // 
            btn_Salad.Location = new Point(812, 14);
            btn_Salad.Margin = new Padding(3, 4, 3, 4);
            btn_Salad.Name = "btn_Salad";
            btn_Salad.Size = new Size(111, 51);
            btn_Salad.TabIndex = 5;
            btn_Salad.Text = "SALAD";
            btn_Salad.UseVisualStyleBackColor = true;
            btn_Salad.Click += btn_Salad_Click;
            // 
            // btn_KimBak
            // 
            btn_KimBak.Location = new Point(204, 11);
            btn_KimBak.Margin = new Padding(3, 4, 3, 4);
            btn_KimBak.Name = "btn_KimBak";
            btn_KimBak.Size = new Size(109, 52);
            btn_KimBak.TabIndex = 2;
            btn_KimBak.Text = "KIMBAK";
            btn_KimBak.UseVisualStyleBackColor = true;
            btn_KimBak.Click += btn_KimBak_Click;
            // 
            // btn_Com_Tron
            // 
            btn_Com_Tron.Location = new Point(412, 11);
            btn_Com_Tron.Margin = new Padding(3, 4, 3, 4);
            btn_Com_Tron.Name = "btn_Com_Tron";
            btn_Com_Tron.Size = new Size(108, 51);
            btn_Com_Tron.TabIndex = 4;
            btn_Com_Tron.Text = "CƠM TRỘN";
            btn_Com_Tron.UseVisualStyleBackColor = true;
            btn_Com_Tron.Click += btn_Com_Tron_Click;
            // 
            // btn_Thit_Nuong
            // 
            btn_Thit_Nuong.Location = new Point(607, 10);
            btn_Thit_Nuong.Margin = new Padding(3, 4, 3, 4);
            btn_Thit_Nuong.Name = "btn_Thit_Nuong";
            btn_Thit_Nuong.Size = new Size(127, 55);
            btn_Thit_Nuong.TabIndex = 3;
            btn_Thit_Nuong.Text = "THỊT NƯỚNG";
            btn_Thit_Nuong.UseVisualStyleBackColor = true;
            btn_Thit_Nuong.Click += btn_Thit_Nuong_Click;
            // 
            // fl_Panel_Thuc_Don
            // 
            fl_Panel_Thuc_Don.AutoScroll = true;
            fl_Panel_Thuc_Don.BorderStyle = BorderStyle.Fixed3D;
            fl_Panel_Thuc_Don.Location = new Point(3, 95);
            fl_Panel_Thuc_Don.Margin = new Padding(3, 4, 3, 4);
            fl_Panel_Thuc_Don.Name = "fl_Panel_Thuc_Don";
            fl_Panel_Thuc_Don.Size = new Size(940, 731);
            fl_Panel_Thuc_Don.TabIndex = 6;
            // 
            // pal_Order
            // 
            pal_Order.BorderStyle = BorderStyle.Fixed3D;
            pal_Order.Location = new Point(944, 4);
            pal_Order.Margin = new Padding(3, 4, 3, 4);
            pal_Order.Name = "pal_Order";
            pal_Order.Size = new Size(434, 821);
            pal_Order.TabIndex = 7;
            // 
            // uc_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Header);
            Controls.Add(fl_Panel_Thuc_Don);
            Controls.Add(pal_Order);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_Menu";
            Size = new Size(1378, 827);
            Load += uc_Menu_Load;
            panel_Header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Header;
        private FlowLayoutPanel fl_Panel_Thuc_Don;
        private Panel pal_Order;
        private Button btn_Salad;
        private Button btn_Com_Tron;
        private Button btn_Thit_Nuong;
        private Button btn_KimBak;
        private Button btn_Tokbokki;
    }
}
