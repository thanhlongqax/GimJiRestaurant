namespace Gimji.GUI.Menu
{
    partial class uc_MonAn
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_MonAn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna_pal_food = new Guna.UI2.WinForms.Guna2Panel();
            guna_btn_buy = new Guna.UI2.WinForms.Guna2CircleButton();
            lb_price = new Label();
            lb_name = new Label();
            guna_pic_image = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna_pal_food.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna_pic_image).BeginInit();
            SuspendLayout();
            // 
            // guna_pal_food
            // 
            guna_pal_food.BorderRadius = 15;
            guna_pal_food.Controls.Add(guna_btn_buy);
            guna_pal_food.Controls.Add(lb_price);
            guna_pal_food.Controls.Add(lb_name);
            guna_pal_food.Controls.Add(guna_pic_image);
            guna_pal_food.CustomizableEdges = customizableEdges7;
            guna_pal_food.FillColor = Color.White;
            guna_pal_food.Location = new Point(0, 22);
            guna_pal_food.Name = "guna_pal_food";
            guna_pal_food.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna_pal_food.Size = new Size(270, 310);
            guna_pal_food.TabIndex = 0;
            // 
            // guna_btn_buy
            // 
            guna_btn_buy.DisabledState.BorderColor = Color.DarkGray;
            guna_btn_buy.DisabledState.CustomBorderColor = Color.DarkGray;
            guna_btn_buy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna_btn_buy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna_btn_buy.FillColor = Color.Transparent;
            guna_btn_buy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna_btn_buy.ForeColor = Color.White;
            guna_btn_buy.Image = (Image)resources.GetObject("guna_btn_buy.Image");
            guna_btn_buy.ImageSize = new Size(40, 40);
            guna_btn_buy.Location = new Point(197, 218);
            guna_btn_buy.Name = "guna_btn_buy";
            guna_btn_buy.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna_btn_buy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna_btn_buy.Size = new Size(40, 40);
            guna_btn_buy.TabIndex = 3;
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_price.ForeColor = Color.FromArgb(64, 0, 0);
            lb_price.Location = new Point(35, 234);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(76, 23);
            lb_price.TabIndex = 2;
            lb_price.Text = "50.000 Đ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_name.ForeColor = Color.FromArgb(64, 0, 0);
            lb_name.Location = new Point(35, 202);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(152, 23);
            lb_name.TabIndex = 1;
            lb_name.Text = "Tokbokki Chicken";
            // 
            // guna_pic_image
            // 
            guna_pic_image.Image = (Image)resources.GetObject("guna_pic_image.Image");
            guna_pic_image.ImageRotate = 0F;
            guna_pic_image.Location = new Point(68, 50);
            guna_pic_image.Name = "guna_pic_image";
            guna_pic_image.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna_pic_image.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna_pic_image.Size = new Size(130, 130);
            guna_pic_image.SizeMode = PictureBoxSizeMode.StretchImage;
            guna_pic_image.TabIndex = 0;
            guna_pic_image.TabStop = false;
            // 
            // uc_MonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna_pal_food);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_MonAn";
            Size = new Size(304, 361);
            guna_pal_food.ResumeLayout(false);
            guna_pal_food.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna_pic_image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna_pal_food;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna_pic_image;
        private Label lb_price;
        private Label lb_name;
        private Guna.UI2.WinForms.Guna2CircleButton guna_btn_buy;
    }
}
