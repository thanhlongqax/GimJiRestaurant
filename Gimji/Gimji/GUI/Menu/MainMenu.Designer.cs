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
            pictureBox1 = new PictureBox();
            button2 = new Button();
            dateTimePicker = new DateTimePicker();
            searchBox = new GroupBox();
            pictureBox_search = new PictureBox();
            searchTextBox = new TextBox();
            logoTop = new PictureBox();
            panel1 = new Panel();
            btn_Logout = new Button();
            btn_Setting = new Button();
            btn_Order = new Button();
            btn_Payment = new Button();
            btn_Menu = new Button();
            btn_Home = new Button();
            btn_HotDished = new Button();
            btn_KimBak = new Button();
            btn_Tokbokki = new Button();
            btn_Com_Tron = new Button();
            btn_Salad = new Button();
            panel2 = new Panel();
            panel_Order = new Panel();
            fl_Panel_Thuc_Don = new FlowLayoutPanel();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoTop).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(209, 10, 45);
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(button2);
            topPanel.Controls.Add(dateTimePicker);
            topPanel.Controls.Add(searchBox);
            topPanel.Controls.Add(logoTop);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1499, 99);
            topPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(236, 220, 199);
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(1374, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(236, 220, 199);
            button2.Location = new Point(1205, 17);
            button2.Name = "button2";
            button2.Size = new Size(149, 63);
            button2.TabIndex = 4;
            button2.Text = "ADD ORDER";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarForeColor = Color.CornflowerBlue;
            dateTimePicker.Location = new Point(907, 36);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(262, 27);
            dateTimePicker.TabIndex = 3;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(236, 220, 199);
            searchBox.Controls.Add(pictureBox_search);
            searchBox.Controls.Add(searchTextBox);
            searchBox.Location = new Point(245, 21);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(294, 59);
            searchBox.TabIndex = 2;
            searchBox.TabStop = false;
            // 
            // pictureBox_search
            // 
            pictureBox_search.Image = Properties.Resources.search;
            pictureBox_search.Location = new Point(227, 8);
            pictureBox_search.Name = "pictureBox_search";
            pictureBox_search.Size = new Size(40, 43);
            pictureBox_search.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_search.TabIndex = 6;
            pictureBox_search.TabStop = false;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.FromArgb(236, 220, 199);
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Location = new Point(11, 19);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(267, 20);
            searchTextBox.TabIndex = 3;
            searchTextBox.Text = "Search product or any order...";
            // 
            // logoTop
            // 
            logoTop.BackColor = Color.FromArgb(236, 220, 199);
            logoTop.Image = Properties.Resources.logo;
            logoTop.Location = new Point(21, 0);
            logoTop.Name = "logoTop";
            logoTop.Size = new Size(161, 100);
            logoTop.SizeMode = PictureBoxSizeMode.Zoom;
            logoTop.TabIndex = 1;
            logoTop.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_Logout);
            panel1.Controls.Add(btn_Setting);
            panel1.Controls.Add(btn_Order);
            panel1.Controls.Add(btn_Payment);
            panel1.Controls.Add(btn_Menu);
            panel1.Controls.Add(btn_Home);
            panel1.Location = new Point(0, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 825);
            panel1.TabIndex = 1;
            // 
            // btn_Logout
            // 
            btn_Logout.BackgroundImage = (Image)resources.GetObject("btn_Logout.BackgroundImage");
            btn_Logout.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Logout.Location = new Point(30, 704);
            btn_Logout.Margin = new Padding(3, 4, 3, 4);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(86, 96);
            btn_Logout.TabIndex = 6;
            btn_Logout.UseVisualStyleBackColor = true;
            // 
            // btn_Setting
            // 
            btn_Setting.BackgroundImage = (Image)resources.GetObject("btn_Setting.BackgroundImage");
            btn_Setting.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Setting.Location = new Point(30, 544);
            btn_Setting.Margin = new Padding(3, 4, 3, 4);
            btn_Setting.Name = "btn_Setting";
            btn_Setting.Size = new Size(86, 89);
            btn_Setting.TabIndex = 5;
            btn_Setting.UseVisualStyleBackColor = true;
            // 
            // btn_Order
            // 
            btn_Order.BackgroundImage = (Image)resources.GetObject("btn_Order.BackgroundImage");
            btn_Order.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Order.Location = new Point(25, 399);
            btn_Order.Margin = new Padding(3, 4, 3, 4);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(86, 91);
            btn_Order.TabIndex = 4;
            btn_Order.UseVisualStyleBackColor = true;
            // 
            // btn_Payment
            // 
            btn_Payment.BackgroundImage = (Image)resources.GetObject("btn_Payment.BackgroundImage");
            btn_Payment.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Payment.Location = new Point(30, 256);
            btn_Payment.Margin = new Padding(3, 4, 3, 4);
            btn_Payment.Name = "btn_Payment";
            btn_Payment.Size = new Size(81, 87);
            btn_Payment.TabIndex = 3;
            btn_Payment.UseVisualStyleBackColor = true;
            // 
            // btn_Menu
            // 
            btn_Menu.BackgroundImage = (Image)resources.GetObject("btn_Menu.BackgroundImage");
            btn_Menu.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Menu.Location = new Point(25, 128);
            btn_Menu.Margin = new Padding(3, 4, 3, 4);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(86, 87);
            btn_Menu.TabIndex = 0;
            btn_Menu.UseVisualStyleBackColor = true;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // btn_Home
            // 
            btn_Home.BackgroundImage = (Image)resources.GetObject("btn_Home.BackgroundImage");
            btn_Home.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Home.Location = new Point(30, 16);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(81, 83);
            btn_Home.TabIndex = 2;
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.MouseHover += button1_MouseHover;
            // 
            // btn_HotDished
            // 
            btn_HotDished.Location = new Point(15, 15);
            btn_HotDished.Margin = new Padding(3, 4, 3, 4);
            btn_HotDished.Name = "btn_HotDished";
            btn_HotDished.Size = new Size(115, 49);
            btn_HotDished.TabIndex = 1;
            btn_HotDished.Text = "HOT DISHED";
            btn_HotDished.UseVisualStyleBackColor = true;
            // 
            // btn_KimBak
            // 
            btn_KimBak.Location = new Point(201, 13);
            btn_KimBak.Margin = new Padding(3, 4, 3, 4);
            btn_KimBak.Name = "btn_KimBak";
            btn_KimBak.Size = new Size(101, 52);
            btn_KimBak.TabIndex = 2;
            btn_KimBak.Text = "KIMBAK";
            btn_KimBak.UseVisualStyleBackColor = true;
            // 
            // btn_Tokbokki
            // 
            btn_Tokbokki.Location = new Point(605, 16);
            btn_Tokbokki.Margin = new Padding(3, 4, 3, 4);
            btn_Tokbokki.Name = "btn_Tokbokki";
            btn_Tokbokki.Size = new Size(86, 49);
            btn_Tokbokki.TabIndex = 3;
            btn_Tokbokki.Text = "TOKBOKKI";
            btn_Tokbokki.UseVisualStyleBackColor = true;
            // 
            // btn_Com_Tron
            // 
            btn_Com_Tron.Location = new Point(395, 15);
            btn_Com_Tron.Margin = new Padding(3, 4, 3, 4);
            btn_Com_Tron.Name = "btn_Com_Tron";
            btn_Com_Tron.Size = new Size(98, 51);
            btn_Com_Tron.TabIndex = 4;
            btn_Com_Tron.Text = "CƠM TRỘN";
            btn_Com_Tron.UseVisualStyleBackColor = true;
            // 
            // btn_Salad
            // 
            btn_Salad.Location = new Point(809, 15);
            btn_Salad.Margin = new Padding(3, 4, 3, 4);
            btn_Salad.Name = "btn_Salad";
            btn_Salad.Size = new Size(99, 51);
            btn_Salad.TabIndex = 5;
            btn_Salad.Text = "SALAD";
            btn_Salad.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btn_Salad);
            panel2.Controls.Add(btn_Com_Tron);
            panel2.Controls.Add(btn_Tokbokki);
            panel2.Controls.Add(btn_KimBak);
            panel2.Controls.Add(btn_HotDished);
            panel2.Location = new Point(147, 107);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 81);
            panel2.TabIndex = 2;
            // 
            // panel_Order
            // 
            panel_Order.BorderStyle = BorderStyle.Fixed3D;
            panel_Order.Location = new Point(1095, 107);
            panel_Order.Margin = new Padding(3, 4, 3, 4);
            panel_Order.Name = "panel_Order";
            panel_Order.Size = new Size(404, 825);
            panel_Order.TabIndex = 4;
            // 
            // fl_Panel_Thuc_Don
            // 
            fl_Panel_Thuc_Don.BorderStyle = BorderStyle.Fixed3D;
            fl_Panel_Thuc_Don.Location = new Point(147, 197);
            fl_Panel_Thuc_Don.Margin = new Padding(3, 4, 3, 4);
            fl_Panel_Thuc_Don.Name = "fl_Panel_Thuc_Don";
            fl_Panel_Thuc_Don.Size = new Size(940, 735);
            fl_Panel_Thuc_Don.TabIndex = 3;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 925);
            Controls.Add(fl_Panel_Thuc_Don);
            Controls.Add(panel_Order);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(topPanel);
            Name = "mainForm";
            Text = "Gimji";
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            searchBox.ResumeLayout(false);
            searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_search).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoTop).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private PictureBox logoTop;
        private DateTimePicker dateTimePicker;
        private Button button2;
        private PictureBox pictureBox1;
        private GroupBox searchBox;
        private PictureBox pictureBox_search;
        private TextBox searchTextBox;
        private Panel panel1;
        private Button btn_Home;
        private Button btn_HotDished;
        private Button btn_KimBak;
        private Button btn_Tokbokki;
        private Button btn_Com_Tron;
        private Button btn_Salad;
        private Panel panel2;
        private Panel panel_Order;
        private Button btn_Logout;
        private Button btn_Setting;
        private Button btn_Order;
        private Button btn_Payment;
        private Button btn_Menu;
        private GroupBox groupBox1;
        private Button button3;
        private PictureBox pictureBox2;
        private FlowLayoutPanel fl_Panel_Thuc_Don;
        private Label txt_MonAn;
        private Label txt_tenMonAn;
    }
}