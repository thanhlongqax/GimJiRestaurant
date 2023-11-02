namespace Gimji.GUI.Menu
{
    partial class uc_MonAnCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_MonAnCart));
            pictureBox1 = new PictureBox();
            btn_add = new Button();
            btn_minus = new Button();
            txt_giaTien = new Label();
            txt_tenMonAn = new Label();
            txt_quanitity = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 129);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            btn_add.BackgroundImage = (Image)resources.GetObject("btn_add.BackgroundImage");
            btn_add.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add.Location = new Point(173, 87);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(34, 31);
            btn_add.TabIndex = 1;
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_minus
            // 
            btn_minus.BackgroundImage = (Image)resources.GetObject("btn_minus.BackgroundImage");
            btn_minus.BackgroundImageLayout = ImageLayout.Stretch;
            btn_minus.Location = new Point(249, 87);
            btn_minus.Margin = new Padding(3, 4, 3, 4);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(39, 31);
            btn_minus.TabIndex = 2;
            btn_minus.UseVisualStyleBackColor = true;
            // 
            // txt_giaTien
            // 
            txt_giaTien.AutoSize = true;
            txt_giaTien.Location = new Point(173, 51);
            txt_giaTien.Name = "txt_giaTien";
            txt_giaTien.Size = new Size(49, 20);
            txt_giaTien.TabIndex = 7;
            txt_giaTien.Text = "$5000";
            // 
            // txt_tenMonAn
            // 
            txt_tenMonAn.AutoSize = true;
            txt_tenMonAn.Location = new Point(173, 17);
            txt_tenMonAn.Name = "txt_tenMonAn";
            txt_tenMonAn.Size = new Size(107, 20);
            txt_tenMonAn.TabIndex = 8;
            txt_tenMonAn.Text = "Tobokki chả cá";
            // 
            // txt_quanitity
            // 
            txt_quanitity.AutoSize = true;
            txt_quanitity.Location = new Point(219, 92);
            txt_quanitity.Name = "txt_quanitity";
            txt_quanitity.Size = new Size(0, 20);
            txt_quanitity.TabIndex = 9;
            // 
            // uc_MonAnCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txt_quanitity);
            Controls.Add(txt_giaTien);
            Controls.Add(txt_tenMonAn);
            Controls.Add(btn_minus);
            Controls.Add(btn_add);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_MonAnCart";
            Size = new Size(362, 133);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_add;
        private Button btn_minus;
        private Label txt_giaTien;
        private Label txt_tenMonAn;
        private Label txt_quanitity;
    }
}
