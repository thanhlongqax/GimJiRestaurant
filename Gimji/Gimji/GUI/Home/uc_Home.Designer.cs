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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Home));
            label1 = new Label();
            pal_header = new Panel();
            btn_secondF = new Guna.UI2.WinForms.Guna2Button();
            btn_firstF = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flow_pal_listtable = new FlowLayoutPanel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pal_inforTable = new Panel();
            pal_status = new Panel();
            flow_pal_table = new FlowLayoutPanel();
            pal_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pal_header
            // 
            pal_header.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pal_header.BackColor = SystemColors.Control;
            pal_header.Controls.Add(btn_secondF);
            pal_header.Controls.Add(btn_firstF);
            pal_header.Controls.Add(pictureBox1);
            pal_header.Controls.Add(label1);
            pal_header.Location = new Point(35, 16);
            pal_header.Name = "pal_header";
            pal_header.Size = new Size(899, 77);
            pal_header.TabIndex = 3;
            // 
            // btn_secondF
            // 
            btn_secondF.BorderRadius = 5;
            btn_secondF.CustomizableEdges = customizableEdges5;
            btn_secondF.DisabledState.BorderColor = Color.DarkGray;
            btn_secondF.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_secondF.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_secondF.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_secondF.FillColor = Color.FromArgb(224, 224, 224);
            btn_secondF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_secondF.ForeColor = Color.Black;
            btn_secondF.HoverState.FillColor = Color.Gray;
            btn_secondF.Location = new Point(744, 14);
            btn_secondF.Name = "btn_secondF";
            btn_secondF.PressedColor = Color.Transparent;
            btn_secondF.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_secondF.Size = new Size(130, 46);
            btn_secondF.TabIndex = 15;
            btn_secondF.Text = "Second Floor";
            // 
            // btn_firstF
            // 
            btn_firstF.BorderRadius = 5;
            btn_firstF.CustomizableEdges = customizableEdges7;
            btn_firstF.DisabledState.BorderColor = Color.DarkGray;
            btn_firstF.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_firstF.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_firstF.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_firstF.FillColor = Color.FromArgb(232, 197, 163);
            btn_firstF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_firstF.ForeColor = Color.Black;
            btn_firstF.HoverState.FillColor = Color.FromArgb(255, 192, 128);
            btn_firstF.Location = new Point(608, 14);
            btn_firstF.Name = "btn_firstF";
            btn_firstF.PressedColor = Color.Transparent;
            btn_firstF.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_firstF.Size = new Size(130, 46);
            btn_firstF.TabIndex = 14;
            btn_firstF.Text = "First Floor";
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
            flow_pal_listtable.Location = new Point(9, 89);
            flow_pal_listtable.Name = "flow_pal_listtable";
            flow_pal_listtable.Size = new Size(394, 695);
            flow_pal_listtable.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 11);
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
            // pal_inforTable
            // 
            pal_inforTable.Location = new Point(39, 725);
            pal_inforTable.Name = "pal_inforTable";
            pal_inforTable.Size = new Size(870, 65);
            pal_inforTable.TabIndex = 9;
            // 
            // pal_status
            // 
            pal_status.Location = new Point(39, 638);
            pal_status.Name = "pal_status";
            pal_status.Size = new Size(879, 59);
            pal_status.TabIndex = 10;
            // 
            // flow_pal_table
            // 
            flow_pal_table.AutoScroll = true;
            flow_pal_table.BackColor = Color.Transparent;
            flow_pal_table.Location = new Point(39, 111);
            flow_pal_table.Name = "flow_pal_table";
            flow_pal_table.Size = new Size(880, 495);
            flow_pal_table.TabIndex = 12;
            // 
            // uc_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pictureBox2);
            Controls.Add(flow_pal_table);
            Controls.Add(pal_status);
            Controls.Add(pal_inforTable);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(pal_header);
            Name = "uc_Home";
            Size = new Size(1369, 829);
            pal_header.ResumeLayout(false);
            pal_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel pal_header;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel pal_inforTable;
        private Panel pal_status;
        private FlowLayoutPanel flow_pal_listtable;
        private FlowLayoutPanel flow_pal_table;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_secondF;
        private Guna.UI2.WinForms.Guna2Button btn_firstF;
    }
}
