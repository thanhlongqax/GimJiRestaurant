namespace Gimji.GUI.Management.ProductManagement
{
    partial class uc_product
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_product));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pal_product = new Guna.UI2.WinForms.Guna2Panel();
            txt_price = new TextBox();
            btn_edit = new Guna.UI2.WinForms.Guna2Button();
            txt_name = new TextBox();
            btn_buy = new Guna.UI2.WinForms.Guna2CircleButton();
            pic_image = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            pal_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_image).BeginInit();
            SuspendLayout();
            // 
            // pal_product
            // 
            pal_product.BackColor = Color.Transparent;
            pal_product.BorderRadius = 10;
            pal_product.Controls.Add(txt_price);
            pal_product.Controls.Add(btn_edit);
            pal_product.Controls.Add(txt_name);
            pal_product.Controls.Add(btn_buy);
            pal_product.Controls.Add(pic_image);
            pal_product.CustomizableEdges = customizableEdges11;
            pal_product.FillColor = Color.White;
            pal_product.Location = new Point(0, 0);
            pal_product.Name = "pal_product";
            pal_product.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pal_product.Size = new Size(205, 220);
            pal_product.TabIndex = 0;
            // 
            // txt_price
            // 
            txt_price.BorderStyle = BorderStyle.None;
            txt_price.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_price.ForeColor = Color.FromArgb(64, 0, 0);
            txt_price.Location = new Point(44, 156);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(99, 18);
            txt_price.TabIndex = 2;
            txt_price.Text = "50.000 Đ ";
            // 
            // btn_edit
            // 
            btn_edit.BorderRadius = 10;
            btn_edit.CustomizableEdges = customizableEdges7;
            btn_edit.DisabledState.BorderColor = Color.DarkGray;
            btn_edit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_edit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_edit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_edit.FillColor = Color.FromArgb(255, 224, 192);
            btn_edit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.FromArgb(128, 64, 64);
            btn_edit.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
            btn_edit.ImageSize = new Size(18, 18);
            btn_edit.Location = new Point(1, 185);
            btn_edit.Name = "btn_edit";
            btn_edit.PressedColor = Color.Transparent;
            btn_edit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_edit.Size = new Size(205, 35);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Edit dish";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_name.ForeColor = Color.FromArgb(64, 0, 0);
            txt_name.Location = new Point(43, 123);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(134, 20);
            txt_name.TabIndex = 1;
            txt_name.Text = "Tokbokki Chicken";
            // 
            // btn_buy
            // 
            btn_buy.DisabledState.BorderColor = Color.DarkGray;
            btn_buy.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_buy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_buy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_buy.FillColor = Color.Transparent;
            btn_buy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_buy.ForeColor = Color.White;
            btn_buy.HoverState.BorderColor = Color.FromArgb(255, 128, 128);
            btn_buy.Image = (Image)resources.GetObject("btn_buy.Image");
            btn_buy.ImageSize = new Size(25, 25);
            btn_buy.Location = new Point(156, 150);
            btn_buy.Name = "btn_buy";
            btn_buy.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btn_buy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_buy.Size = new Size(25, 25);
            btn_buy.TabIndex = 7;
            // 
            // pic_image
            // 
            pic_image.Image = (Image)resources.GetObject("pic_image.Image");
            pic_image.ImageRotate = 0F;
            pic_image.Location = new Point(67, 37);
            pic_image.Name = "pic_image";
            pic_image.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pic_image.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pic_image.Size = new Size(80, 80);
            pic_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_image.TabIndex = 4;
            pic_image.TabStop = false;
            // 
            // uc_product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pal_product);
            Name = "uc_product";
            Size = new Size(232, 243);
            pal_product.ResumeLayout(false);
            pal_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pal_product;
        private Guna.UI2.WinForms.Guna2CircleButton btn_buy;
        private Label lb_price;
        private Label lb_name;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_image;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private TextBox txt_name;
        private TextBox txt_price;
    }
}
