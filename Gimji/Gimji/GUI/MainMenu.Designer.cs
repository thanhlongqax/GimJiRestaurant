namespace Gimji
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            topPanel = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            date_time = new Label();
            panel3 = new Panel();
            searchTextBox = new TextBox();
            pictureBox_search = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            btn_Logout = new Button();
            btn_Setting = new Button();
            btn_Order = new Button();
            btn_Payment = new Button();
            btn_Menu = new Button();
            btn_Home = new Button();
            panel_Menu = new Panel();
            pictureBox3 = new PictureBox();
            topPanel.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_search).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(209, 10, 45);
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(panel5);
            topPanel.Controls.Add(panel4);
            topPanel.Controls.Add(panel3);
            topPanel.Controls.Add(panel2);
            topPanel.Controls.Add(button2);
            topPanel.Location = new Point(0, 1);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1500, 97);
            topPanel.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(1380, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(79, 63);
            panel5.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(date_time);
            panel4.Location = new Point(915, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(251, 31);
            panel4.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 18);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // date_time
            // 
            date_time.AutoSize = true;
            date_time.Location = new Point(34, 7);
            date_time.Name = "date_time";
            date_time.Size = new Size(42, 20);
            date_time.TabIndex = 8;
            date_time.Text = "Time";
            date_time.Click += date_time_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(searchTextBox);
            panel3.Controls.Add(pictureBox_search);
            panel3.Location = new Point(224, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 58);
            panel3.TabIndex = 7;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.FromArgb(236, 220, 199);
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.ForeColor = Color.Gray;
            searchTextBox.Location = new Point(30, 20);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(267, 20);
            searchTextBox.TabIndex = 3;
            searchTextBox.Text = "Search product or any order...";
            // 
            // pictureBox_search
            // 
            pictureBox_search.BackgroundImage = (Image)resources.GetObject("pictureBox_search.BackgroundImage");
            pictureBox_search.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_search.Location = new Point(322, 20);
            pictureBox_search.Name = "pictureBox_search";
            pictureBox_search.Size = new Size(22, 22);
            pictureBox_search.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_search.TabIndex = 6;
            pictureBox_search.TabStop = false;
            pictureBox_search.Click += pictureBox_search_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(11, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 87);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(8, 17);
            button1.Name = "button1";
            button1.Size = new Size(130, 67);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1188, 18);
            button2.Name = "button2";
            button2.Size = new Size(163, 63);
            button2.TabIndex = 4;
            button2.Text = "ADD ORDER";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btn_Logout);
            panel1.Controls.Add(btn_Setting);
            panel1.Controls.Add(btn_Order);
            panel1.Controls.Add(btn_Payment);
            panel1.Controls.Add(btn_Menu);
            panel1.Controls.Add(btn_Home);
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(97, 885);
            panel1.TabIndex = 1;
            // 
            // btn_Logout
            // 
            btn_Logout.BackgroundImage = (Image)resources.GetObject("btn_Logout.BackgroundImage");
            btn_Logout.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Logout.FlatAppearance.BorderSize = 0;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Location = new Point(20, 699);
            btn_Logout.Margin = new Padding(3, 4, 3, 4);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(55, 55);
            btn_Logout.TabIndex = 6;
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_Setting
            // 
            btn_Setting.BackgroundImage = (Image)resources.GetObject("btn_Setting.BackgroundImage");
            btn_Setting.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Setting.FlatAppearance.BorderSize = 0;
            btn_Setting.FlatStyle = FlatStyle.Flat;
            btn_Setting.Location = new Point(20, 480);
            btn_Setting.Margin = new Padding(3, 4, 3, 4);
            btn_Setting.Name = "btn_Setting";
            btn_Setting.Size = new Size(55, 55);
            btn_Setting.TabIndex = 5;
            btn_Setting.UseVisualStyleBackColor = true;
            btn_Setting.Click += btn_Setting_Click;
            // 
            // btn_Order
            // 
            btn_Order.BackgroundImage = (Image)resources.GetObject("btn_Order.BackgroundImage");
            btn_Order.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Order.FlatAppearance.BorderSize = 0;
            btn_Order.FlatStyle = FlatStyle.Flat;
            btn_Order.Location = new Point(20, 358);
            btn_Order.Margin = new Padding(3, 4, 3, 4);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(55, 55);
            btn_Order.TabIndex = 4;
            btn_Order.UseVisualStyleBackColor = true;
            btn_Order.Click += btn_Order_Click;
            // 
            // btn_Payment
            // 
            btn_Payment.BackgroundImage = (Image)resources.GetObject("btn_Payment.BackgroundImage");
            btn_Payment.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Payment.FlatAppearance.BorderSize = 0;
            btn_Payment.FlatStyle = FlatStyle.Flat;
            btn_Payment.Location = new Point(25, 243);
            btn_Payment.Margin = new Padding(3, 4, 3, 4);
            btn_Payment.Name = "btn_Payment";
            btn_Payment.Size = new Size(55, 55);
            btn_Payment.TabIndex = 3;
            btn_Payment.UseVisualStyleBackColor = true;
            btn_Payment.Click += btn_Payment_Click;
            // 
            // btn_Menu
            // 
            btn_Menu.BackgroundImage = (Image)resources.GetObject("btn_Menu.BackgroundImage");
            btn_Menu.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Menu.FlatAppearance.BorderSize = 0;
            btn_Menu.FlatStyle = FlatStyle.Flat;
            btn_Menu.Location = new Point(25, 122);
            btn_Menu.Margin = new Padding(3, 4, 3, 4);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(55, 55);
            btn_Menu.TabIndex = 0;
            btn_Menu.UseVisualStyleBackColor = true;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // btn_Home
            // 
            btn_Home.BackgroundImage = (Image)resources.GetObject("btn_Home.BackgroundImage");
            btn_Home.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Home.FlatAppearance.BorderSize = 0;
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.Location = new Point(25, 20);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(55, 55);
            btn_Home.TabIndex = 2;
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = Color.Transparent;
            panel_Menu.BackgroundImageLayout = ImageLayout.None;
            panel_Menu.Location = new Point(109, 100);
            panel_Menu.Margin = new Padding(3, 4, 3, 4);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(1367, 827);
            panel_Menu.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Firebrick;
            pictureBox3.Location = new Point(96, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1, 824);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1482, 933);
            Controls.Add(pictureBox3);
            Controls.Add(panel_Menu);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            MaximizeBox = false;
            Name = "mainForm";
            Text = "Gimji";
            Load += mainForm_Load_1;
            topPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_search).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_search;
        private TextBox searchTextBox;
        private Panel panel1;
        private Button btn_Home;
        private Button btn_Logout;
        private Button btn_Setting;
        private Button btn_Order;
        private Button btn_Payment;
        private Button btn_Menu;
        private GroupBox groupBox1;
        private Button button3;
        private Label txt_MonAn;
        private Label txt_tenMonAn;
        private Panel panel_Menu;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Label date_time;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel5;
        private PictureBox pictureBox3;
    }
}