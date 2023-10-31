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
            txt_tenMonAn = new Label();
            txt_giaTien = new Label();
            pictureBox_hinhMonAn = new PictureBox();
            btn_Cart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_hinhMonAn).BeginInit();
            SuspendLayout();
            // 
            // txt_tenMonAn
            // 
            txt_tenMonAn.AutoSize = true;
            txt_tenMonAn.Location = new Point(54, 208);
            txt_tenMonAn.Name = "txt_tenMonAn";
            txt_tenMonAn.Size = new Size(0, 20);
            txt_tenMonAn.TabIndex = 6;
            // 
            // txt_giaTien
            // 
            txt_giaTien.AutoSize = true;
            txt_giaTien.Location = new Point(73, 236);
            txt_giaTien.Name = "txt_giaTien";
            txt_giaTien.Size = new Size(0, 20);
            txt_giaTien.TabIndex = 5;
            // 
            // pictureBox_hinhMonAn
            // 
            pictureBox_hinhMonAn.BackColor = Color.Transparent;
            pictureBox_hinhMonAn.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_hinhMonAn.Location = new Point(22, 16);
            pictureBox_hinhMonAn.Margin = new Padding(3, 4, 3, 4);
            pictureBox_hinhMonAn.Name = "pictureBox_hinhMonAn";
            pictureBox_hinhMonAn.Size = new Size(177, 184);
            pictureBox_hinhMonAn.TabIndex = 4;
            pictureBox_hinhMonAn.TabStop = false;
            // 
            // btn_Cart
            // 
            btn_Cart.BackgroundImage = (Image)resources.GetObject("btn_Cart.BackgroundImage");
            btn_Cart.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Cart.Location = new Point(167, 208);
            btn_Cart.Margin = new Padding(3, 4, 3, 4);
            btn_Cart.Name = "btn_Cart";
            btn_Cart.Size = new Size(43, 48);
            btn_Cart.TabIndex = 3;
            btn_Cart.UseVisualStyleBackColor = true;
            // 
            // uc_MonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txt_giaTien);
            Controls.Add(txt_tenMonAn);
            Controls.Add(pictureBox_hinhMonAn);
            Controls.Add(btn_Cart);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_MonAn";
            Size = new Size(231, 279);
            ((System.ComponentModel.ISupportInitialize)pictureBox_hinhMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txt_tenMonAn;
        private Label txt_giaTien;
        private PictureBox pictureBox_hinhMonAn;
        private Button btn_Cart;
    }
}
