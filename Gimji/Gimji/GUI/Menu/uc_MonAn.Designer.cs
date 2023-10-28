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
            txt_MonAn = new Label();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_tenMonAn
            // 
            txt_tenMonAn.AutoSize = true;
            txt_tenMonAn.Location = new Point(47, 156);
            txt_tenMonAn.Name = "txt_tenMonAn";
            txt_tenMonAn.Size = new Size(85, 15);
            txt_tenMonAn.TabIndex = 6;
            txt_tenMonAn.Text = "Tobokki chả cá";
            // 
            // txt_MonAn
            // 
            txt_MonAn.AutoSize = true;
            txt_MonAn.Location = new Point(64, 177);
            txt_MonAn.Name = "txt_MonAn";
            txt_MonAn.Size = new Size(37, 15);
            txt_MonAn.TabIndex = 5;
            txt_MonAn.Text = "$5000";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(19, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 138);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(138, 156);
            button3.Name = "button3";
            button3.Size = new Size(38, 36);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // uc_MonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txt_MonAn);
            Controls.Add(txt_tenMonAn);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Name = "uc_MonAn";
            Size = new Size(202, 209);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txt_tenMonAn;
        private Label txt_MonAn;
        private PictureBox pictureBox2;
        private Button button3;
    }
}
