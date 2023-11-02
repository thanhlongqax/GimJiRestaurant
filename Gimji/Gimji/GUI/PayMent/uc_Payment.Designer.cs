namespace Gimji.GUI.PayMent
{
    partial class uc_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Payment));
            panel2 = new Panel();
            label14 = new Label();
            label12 = new Label();
            panel4 = new Panel();
            txt_TotalOrder = new Label();
            label11 = new Label();
            btn_delete = new Button();
            btn_submit = new Button();
            label7 = new Label();
            dateTimePicker_Birthday = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label_username_register = new Label();
            comboBox_Gender = new ComboBox();
            txt_phoneNumber = new TextBox();
            txt_FullName = new TextBox();
            panel5 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            fl_panel_ThucDon_Payment = new FlowLayoutPanel();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txt_quanity_payment = new Label();
            radioButton1 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(119, 24, 24);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(944, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 793);
            panel2.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(233, 214, 147);
            label14.Location = new Point(30, 83);
            label14.Name = "label14";
            label14.Size = new Size(240, 23);
            label14.TabIndex = 17;
            label14.Text = "3 payment method available";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(233, 214, 147);
            label12.Location = new Point(18, 12);
            label12.Name = "label12";
            label12.Size = new Size(159, 46);
            label12.TabIndex = 15;
            label12.Text = "Payment";
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txt_TotalOrder);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(btn_delete);
            panel4.Controls.Add(btn_submit);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(dateTimePicker_Birthday);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label_username_register);
            panel4.Controls.Add(comboBox_Gender);
            panel4.Controls.Add(txt_phoneNumber);
            panel4.Controls.Add(txt_FullName);
            panel4.Location = new Point(3, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(393, 492);
            panel4.TabIndex = 4;
            // 
            // txt_TotalOrder
            // 
            txt_TotalOrder.AutoSize = true;
            txt_TotalOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TotalOrder.ForeColor = Color.White;
            txt_TotalOrder.Location = new Point(299, 337);
            txt_TotalOrder.Name = "txt_TotalOrder";
            txt_TotalOrder.Size = new Size(0, 28);
            txt_TotalOrder.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(216, 337);
            label11.Name = "label11";
            label11.Size = new Size(54, 28);
            label11.TabIndex = 13;
            label11.Text = "Total";
            // 
            // btn_delete
            // 
            btn_delete.BackgroundImage = (Image)resources.GetObject("btn_delete.BackgroundImage");
            btn_delete.BackgroundImageLayout = ImageLayout.Stretch;
            btn_delete.Location = new Point(24, 393);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(171, 67);
            btn_delete.TabIndex = 12;
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            btn_submit.BackgroundImage = (Image)resources.GetObject("btn_submit.BackgroundImage");
            btn_submit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_submit.Location = new Point(216, 393);
            btn_submit.Margin = new Padding(3, 4, 3, 4);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(169, 67);
            btn_submit.TabIndex = 11;
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(233, 214, 147);
            label7.Location = new Point(146, 244);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 10;
            label7.Text = "Birthday";
            // 
            // dateTimePicker_Birthday
            // 
            dateTimePicker_Birthday.Location = new Point(144, 273);
            dateTimePicker_Birthday.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            dateTimePicker_Birthday.Size = new Size(241, 27);
            dateTimePicker_Birthday.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(233, 214, 147);
            label6.Location = new Point(24, 244);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 8;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(233, 214, 147);
            label5.Location = new Point(24, 128);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // label_username_register
            // 
            label_username_register.AutoSize = true;
            label_username_register.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_username_register.ForeColor = Color.FromArgb(233, 214, 147);
            label_username_register.Location = new Point(24, 33);
            label_username_register.Name = "label_username_register";
            label_username_register.Size = new Size(87, 23);
            label_username_register.TabIndex = 6;
            label_username_register.Text = "Customer";
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox_Gender.Location = new Point(24, 273);
            comboBox_Gender.Margin = new Padding(3, 4, 3, 4);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(86, 28);
            comboBox_Gender.TabIndex = 5;
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.Location = new Point(24, 157);
            txt_phoneNumber.Margin = new Padding(3, 4, 3, 4);
            txt_phoneNumber.Multiline = true;
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(341, 59);
            txt_phoneNumber.TabIndex = 1;
            // 
            // txt_FullName
            // 
            txt_FullName.Location = new Point(24, 63);
            txt_FullName.Margin = new Padding(3, 4, 3, 4);
            txt_FullName.Multiline = true;
            txt_FullName.Name = "txt_FullName";
            txt_FullName.Size = new Size(341, 60);
            txt_FullName.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Location = new Point(3, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 136);
            panel5.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(282, 1);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(103, 101);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(-2, 1);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(103, 101);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(146, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 101);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // fl_panel_ThucDon_Payment
            // 
            fl_panel_ThucDon_Payment.AutoScroll = true;
            fl_panel_ThucDon_Payment.BackColor = Color.FromArgb(119, 24, 24);
            fl_panel_ThucDon_Payment.BorderStyle = BorderStyle.Fixed3D;
            fl_panel_ThucDon_Payment.Location = new Point(3, 164);
            fl_panel_ThucDon_Payment.Margin = new Padding(3, 4, 3, 4);
            fl_panel_ThucDon_Payment.Name = "fl_panel_ThucDon_Payment";
            fl_panel_ThucDon_Payment.Size = new Size(924, 608);
            fl_panel_ThucDon_Payment.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(119, 24, 24);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_quanity_payment);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 29);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 125);
            panel1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(701, 83);
            label10.Name = "label10";
            label10.Size = new Size(83, 28);
            label10.TabIndex = 12;
            label10.Text = "Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(418, 83);
            label9.Name = "label9";
            label9.Size = new Size(81, 28);
            label9.TabIndex = 11;
            label9.Text = "Quanity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(217, 83);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 10;
            label8.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 83);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 6;
            label4.Text = "Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 180, 79);
            label3.Location = new Point(793, 29);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 5;
            label3.Text = "12:00";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(738, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 37);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txt_quanity_payment
            // 
            txt_quanity_payment.AutoSize = true;
            txt_quanity_payment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quanity_payment.ForeColor = Color.FromArgb(255, 180, 79);
            txt_quanity_payment.Location = new Point(505, 19);
            txt_quanity_payment.Name = "txt_quanity_payment";
            txt_quanity_payment.Size = new Size(23, 28);
            txt_quanity_payment.TabIndex = 3;
            txt_quanity_payment.Text = "1";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(418, 19);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 32);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "TABLE";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(91, 21);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "#123";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "ORDER";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // uc_Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(fl_panel_ThucDon_Payment);
            Controls.Add(panel2);
            Name = "uc_Payment";
            Size = new Size(1352, 773);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private FlowLayoutPanel fl_panel_ThucDon_Payment;
        private Panel panel1;
        private Label txt_quanity_payment;
        private RadioButton radioButton1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private ListView listView1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox_Gender;
        private Label txt_TotalOrder;
        private Label label11;
        private Button btn_delete;
        private Button btn_submit;
        private Label label7;
        private DateTimePicker dateTimePicker_Birthday;
        private Label label6;
        private Label label5;
        private Label label_username_register;
        private TextBox txt_phoneNumber;
        private TextBox txt_FullName;
        private Label label14;
        private Label label12;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
