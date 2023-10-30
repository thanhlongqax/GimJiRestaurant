using Gimji.GUI.PayMent;
using Gimji.Properties;

namespace Gimji.GUI.Home
{
    partial class uc_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Home));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(242, 46);
            label1.TabIndex = 0;
            label1.Text = "Choose Table";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(565, 14);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 1;
            button1.Text = "First Floor";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(723, 14);
            button2.Name = "button2";
            button2.Size = new Size(129, 46);
            button2.TabIndex = 2;
            button2.Text = "Second Floor";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(36, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 77);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(965, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 724);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(23, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 626);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 11);
            label2.Name = "label2";
            label2.Size = new Size(208, 46);
            label2.TabIndex = 3;
            label2.Text = "TABLE LIST";
            // 
            // panel4
            // 
            panel4.Location = new Point(50, 134);
            panel4.Name = "panel4";
            panel4.Size = new Size(868, 420);
            panel4.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(53, 581);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(864, 1);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox3.Location = new Point(938, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1, 720);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Location = new Point(50, 689);
            panel5.Name = "panel5";
            panel5.Size = new Size(870, 65);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Location = new Point(52, 608);
            panel6.Name = "panel6";
            panel6.Size = new Size(865, 52);
            panel6.TabIndex = 10;
            // 
            // uc_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "uc_Home";
            Size = new Size(1398, 778);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Panel panel6;
    }
}
