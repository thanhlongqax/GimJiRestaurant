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
            flow_pal_listtable = new FlowLayoutPanel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            panel6 = new Panel();
            flow_pal_table = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(35, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 77);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(flow_pal_listtable);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(949, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 800);
            panel2.TabIndex = 4;
            // 
            // flow_pal_listtable
            // 
            flow_pal_listtable.AutoScroll = true;
            flow_pal_listtable.Location = new Point(3, 89);
            flow_pal_listtable.Name = "flow_pal_listtable";
            flow_pal_listtable.Size = new Size(407, 695);
            flow_pal_listtable.TabIndex = 4;
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
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(39, 631);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(880, 1);
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
            panel5.Location = new Point(39, 725);
            panel5.Name = "panel5";
            panel5.Size = new Size(870, 65);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Location = new Point(39, 638);
            panel6.Name = "panel6";
            panel6.Size = new Size(879, 59);
            panel6.TabIndex = 10;
            // 
            // flow_pal_table
            // 
            flow_pal_table.BackColor = Color.Transparent;
            flow_pal_table.Location = new Point(39, 134);
            flow_pal_table.Name = "flow_pal_table";
            flow_pal_table.Size = new Size(880, 472);
            flow_pal_table.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(3, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(880, 1);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // uc_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox2);
            Controls.Add(flow_pal_table);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "uc_Home";
            Size = new Size(1367, 827);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Panel panel6;
        private FlowLayoutPanel flow_pal_listtable;
        private FlowLayoutPanel flow_pal_table;
        private PictureBox pictureBox1;
    }
}
