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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_MonAn));
            btn_Cart = new Button();
            txt_TenMonAn = new Label();
            txt_GiaTien = new Label();
            pictureBox_hinhAnh = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_hinhAnh).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cart
            // 
            btn_Cart.BackColor = Color.Transparent;
            btn_Cart.BackgroundImage = (Image)resources.GetObject("btn_Cart.BackgroundImage");
            btn_Cart.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Cart.Location = new Point(186, 233);
            btn_Cart.Name = "btn_Cart";
            btn_Cart.Size = new Size(45, 46);
            btn_Cart.TabIndex = 5;
            btn_Cart.UseVisualStyleBackColor = false;
            btn_Cart.Click += btn_Cart_Click;
            // 
            // txt_TenMonAn
            // 
            txt_TenMonAn.AutoSize = true;
            txt_TenMonAn.BackColor = Color.Transparent;
            txt_TenMonAn.Location = new Point(19, 11);
            txt_TenMonAn.Name = "txt_TenMonAn";
            txt_TenMonAn.Size = new Size(50, 20);
            txt_TenMonAn.TabIndex = 6;
            txt_TenMonAn.Text = "label1";
            // 
            // txt_GiaTien
            // 
            txt_GiaTien.AutoSize = true;
            txt_GiaTien.BackColor = Color.Transparent;
            txt_GiaTien.Location = new Point(19, 52);
            txt_GiaTien.Name = "txt_GiaTien";
            txt_GiaTien.RightToLeft = RightToLeft.No;
            txt_GiaTien.Size = new Size(50, 20);
            txt_GiaTien.TabIndex = 7;
            txt_GiaTien.Text = "label2";
            // 
            // pictureBox_hinhAnh
            // 
            pictureBox_hinhAnh.BackColor = Color.Transparent;
            pictureBox_hinhAnh.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_hinhAnh.Location = new Point(23, 29);
            pictureBox_hinhAnh.Name = "pictureBox_hinhAnh";
            pictureBox_hinhAnh.Size = new Size(191, 154);
            pictureBox_hinhAnh.TabIndex = 8;
            pictureBox_hinhAnh.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_GiaTien);
            panel1.Controls.Add(txt_TenMonAn);
            panel1.Location = new Point(23, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 85);
            panel1.TabIndex = 10;
            // 
            // uc_MonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(pictureBox_hinhAnh);
            Controls.Add(btn_Cart);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_MonAn";
            Size = new Size(229, 277);
            ((System.ComponentModel.ISupportInitialize)pictureBox_hinhAnh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Cart;
        private Label txt_TenMonAn;
        private Label txt_GiaTien;
        private PictureBox pictureBox_hinhAnh;
        private Panel panel1;
    }
}
