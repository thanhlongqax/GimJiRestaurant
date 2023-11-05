namespace Gimji.GUI.Home
{
    partial class uc_listTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_listTable));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pic_status = new PictureBox();
            lb_time = new Label();
            lb_numGuest = new Label();
            lb_name = new Label();
            btn_table = new Button();
            btn_edit = new Button();
            btn_remove = new Button();
            pal_pic = new PictureBox();
            lb_status = new Label();
            pal_listTable = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)pic_status).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pal_pic).BeginInit();
            pal_listTable.SuspendLayout();
            SuspendLayout();
            // 
            // pic_status
            // 
            pic_status.BackColor = Color.Transparent;
            pic_status.BackgroundImage = (Image)resources.GetObject("pic_status.BackgroundImage");
            pic_status.BackgroundImageLayout = ImageLayout.Stretch;
            pic_status.Location = new Point(233, 20);
            pic_status.Name = "pic_status";
            pic_status.Size = new Size(20, 20);
            pic_status.TabIndex = 20;
            pic_status.TabStop = false;
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.FlatStyle = FlatStyle.Flat;
            lb_time.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_time.Location = new Point(83, 59);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(43, 19);
            lb_time.TabIndex = 19;
            lb_time.Text = "Time";
            // 
            // lb_numGuest
            // 
            lb_numGuest.AutoSize = true;
            lb_numGuest.FlatStyle = FlatStyle.Flat;
            lb_numGuest.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_numGuest.Location = new Point(83, 40);
            lb_numGuest.Name = "lb_numGuest";
            lb_numGuest.Size = new Size(127, 19);
            lb_numGuest.TabIndex = 18;
            lb_numGuest.Text = "Number of guest";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.FlatStyle = FlatStyle.Flat;
            lb_name.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_name.Location = new Point(82, 13);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(69, 28);
            lb_name.TabIndex = 17;
            lb_name.Text = "Name";
            // 
            // btn_table
            // 
            btn_table.BackColor = Color.DarkGray;
            btn_table.FlatAppearance.BorderSize = 0;
            btn_table.FlatStyle = FlatStyle.Flat;
            btn_table.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_table.ForeColor = SystemColors.ActiveCaptionText;
            btn_table.Location = new Point(19, 17);
            btn_table.Name = "btn_table";
            btn_table.Size = new Size(53, 47);
            btn_table.TabIndex = 16;
            btn_table.Text = "T1";
            btn_table.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Transparent;
            btn_edit.BackgroundImage = (Image)resources.GetObject("btn_edit.BackgroundImage");
            btn_edit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Location = new Point(295, 57);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(20, 20);
            btn_edit.TabIndex = 15;
            btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Transparent;
            btn_remove.BackgroundImage = (Image)resources.GetObject("btn_remove.BackgroundImage");
            btn_remove.BackgroundImageLayout = ImageLayout.Stretch;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Location = new Point(268, 57);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(20, 20);
            btn_remove.TabIndex = 14;
            btn_remove.UseVisualStyleBackColor = false;
            // 
            // pal_pic
            // 
            pal_pic.BackgroundImage = (Image)resources.GetObject("pal_pic.BackgroundImage");
            pal_pic.BackgroundImageLayout = ImageLayout.Stretch;
            pal_pic.Location = new Point(10, 6);
            pal_pic.Name = "pal_pic";
            pal_pic.Size = new Size(68, 68);
            pal_pic.TabIndex = 13;
            pal_pic.TabStop = false;
            // 
            // lb_status
            // 
            lb_status.AutoSize = true;
            lb_status.BackColor = Color.Transparent;
            lb_status.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lb_status.Location = new Point(255, 17);
            lb_status.Name = "lb_status";
            lb_status.Size = new Size(82, 23);
            lb_status.TabIndex = 21;
            lb_status.Text = "Occupied";
            // 
            // pal_listTable
            // 
            pal_listTable.BorderRadius = 10;
            pal_listTable.Controls.Add(btn_table);
            pal_listTable.Controls.Add(lb_status);
            pal_listTable.Controls.Add(pal_pic);
            pal_listTable.Controls.Add(pic_status);
            pal_listTable.Controls.Add(btn_remove);
            pal_listTable.Controls.Add(lb_time);
            pal_listTable.Controls.Add(btn_edit);
            pal_listTable.Controls.Add(lb_numGuest);
            pal_listTable.Controls.Add(lb_name);
            pal_listTable.CustomizableEdges = customizableEdges1;
            pal_listTable.FillColor = Color.White;
            pal_listTable.Location = new Point(0, 0);
            pal_listTable.Name = "pal_listTable";
            pal_listTable.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pal_listTable.Size = new Size(347, 85);
            pal_listTable.TabIndex = 22;
            // 
            // uc_listTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pal_listTable);
            DoubleBuffered = true;
            Name = "uc_listTable";
            Size = new Size(347, 93);
            ((System.ComponentModel.ISupportInitialize)pic_status).EndInit();
            ((System.ComponentModel.ISupportInitialize)pal_pic).EndInit();
            pal_listTable.ResumeLayout(false);
            pal_listTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_status;
        private Label lb_time;
        private Label lb_numGuest;
        private Label lb_name;
        private Button btn_table;
        private Button btn_edit;
        private Button btn_remove;
        private PictureBox pal_pic;
        private Label lb_status;
        private Guna.UI2.WinForms.Guna2Panel pal_listTable;
    }
}
