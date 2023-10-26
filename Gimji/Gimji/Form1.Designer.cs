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
            topPanel = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            dateTimePicker = new DateTimePicker();
            searchBox = new GroupBox();
            pictureBox_search = new PictureBox();
            searchTextBox = new TextBox();
            logoTop = new PictureBox();
            panel1 = new Panel();
            pictureBox_logout = new PictureBox();
            pictureBox_setting = new PictureBox();
            pictureBox_order = new PictureBox();
            pictureBox_payment = new PictureBox();
            pictureBox_menu = new PictureBox();
            pictureBox_home = new PictureBox();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoTop).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_setting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_payment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_home).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(209, 10, 45);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(button2);
            topPanel.Controls.Add(dateTimePicker);
            topPanel.Controls.Add(searchBox);
            topPanel.Controls.Add(logoTop);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1500, 100);
            topPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(236, 220, 199);
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(1374, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(236, 220, 199);
            button2.Location = new Point(1204, 17);
            button2.Name = "button2";
            button2.Size = new Size(148, 63);
            button2.TabIndex = 4;
            button2.Text = "ADD ORDER";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarForeColor = Color.CornflowerBlue;
            dateTimePicker.Location = new Point(908, 36);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(262, 27);
            dateTimePicker.TabIndex = 3;
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(236, 220, 199);
            searchBox.Controls.Add(pictureBox_search);
            searchBox.Controls.Add(searchTextBox);
            searchBox.Location = new Point(244, 21);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(294, 58);
            searchBox.TabIndex = 2;
            searchBox.TabStop = false;
            // 
            // pictureBox_search
            // 
            pictureBox_search.Cursor = Cursors.No;
            pictureBox_search.Location = new Point(227, 8);
            pictureBox_search.Name = "pictureBox_search";
            pictureBox_search.Size = new Size(40, 42);
            pictureBox_search.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_search.TabIndex = 6;
            pictureBox_search.TabStop = false;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.FromArgb(236, 220, 199);
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Location = new Point(12, 18);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(267, 20);
            searchTextBox.TabIndex = 3;
            searchTextBox.Text = "Search product or any order...";
            // 
            // logoTop
            // 
            logoTop.BackColor = Color.FromArgb(236, 220, 199);
            logoTop.Image = Properties.Resources.logo;
            logoTop.Location = new Point(20, 0);
            logoTop.Name = "logoTop";
            logoTop.Size = new Size(161, 100);
            logoTop.SizeMode = PictureBoxSizeMode.Zoom;
            logoTop.TabIndex = 1;
            logoTop.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox_logout);
            panel1.Controls.Add(pictureBox_setting);
            panel1.Controls.Add(pictureBox_order);
            panel1.Controls.Add(pictureBox_payment);
            panel1.Controls.Add(pictureBox_menu);
            panel1.Controls.Add(pictureBox_home);
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 1400);
            panel1.TabIndex = 1;
            // 
            // pictureBox_logout
            // 
            pictureBox_logout.Location = new Point(25, 722);
            pictureBox_logout.Name = "pictureBox_logout";
            pictureBox_logout.Size = new Size(70, 70);
            pictureBox_logout.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logout.TabIndex = 5;
            pictureBox_logout.TabStop = false;
            // 
            // pictureBox_setting
            // 
            pictureBox_setting.Location = new Point(25, 603);
            pictureBox_setting.Name = "pictureBox_setting";
            pictureBox_setting.Size = new Size(70, 70);
            pictureBox_setting.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_setting.TabIndex = 4;
            pictureBox_setting.TabStop = false;
            // 
            // pictureBox_order
            // 
            pictureBox_order.Location = new Point(25, 471);
            pictureBox_order.Name = "pictureBox_order";
            pictureBox_order.Size = new Size(70, 70);
            pictureBox_order.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_order.TabIndex = 3;
            pictureBox_order.TabStop = false;
            // 
            // pictureBox_payment
            // 
            pictureBox_payment.Location = new Point(25, 325);
            pictureBox_payment.Name = "pictureBox_payment";
            pictureBox_payment.Size = new Size(70, 70);
            pictureBox_payment.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_payment.TabIndex = 2;
            pictureBox_payment.TabStop = false;
            // 
            // pictureBox_menu
            // 
            pictureBox_menu.Location = new Point(25, 185);
            pictureBox_menu.Name = "pictureBox_menu";
            pictureBox_menu.Size = new Size(70, 70);
            pictureBox_menu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_menu.TabIndex = 1;
            pictureBox_menu.TabStop = false;
            // 
            // pictureBox_home
            // 
            pictureBox_home.Image = Properties.Resources.home;
            pictureBox_home.Location = new Point(25, 46);
            pictureBox_home.Name = "pictureBox_home";
            pictureBox_home.Size = new Size(70, 70);
            pictureBox_home.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_home.TabIndex = 0;
            pictureBox_home.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 933);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Name = "mainForm";
            Text = "h";
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            searchBox.ResumeLayout(false);
            searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_search).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoTop).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_setting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_order).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_payment).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_home).EndInit();
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
        private PictureBox pictureBox_menu;
        private PictureBox pictureBox_home;
        private PictureBox pictureBox_setting;
        private PictureBox pictureBox_order;
        private PictureBox pictureBox_payment;
        private PictureBox pictureBox_logout;
    }
}