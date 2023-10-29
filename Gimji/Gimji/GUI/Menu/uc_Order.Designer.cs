namespace Gimji.GUI.Menu
{
    partial class uc_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Order));
            label1 = new Label();
            txt_id = new Label();
            btn_DineIn = new Button();
            btn_Togo = new Button();
            btn_Delivery = new Button();
            fl_Panel_Cart = new FlowLayoutPanel();
            btn_Trash = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txt_vouccher = new TextBox();
            panel_Cart_footer = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            btn_SenOrder = new Button();
            btn_CancelOrder = new Button();
            panel2 = new Panel();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Cart_footer.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font(".VnArialH", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "ORDER";
            // 
            // txt_id
            // 
            txt_id.AutoSize = true;
            txt_id.Font = new Font(".VnArialH", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(131, 26);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(0, 25);
            txt_id.TabIndex = 1;
            // 
            // btn_DineIn
            // 
            btn_DineIn.BackColor = Color.FromArgb(190, 30, 45);
            btn_DineIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DineIn.ForeColor = Color.White;
            btn_DineIn.Location = new Point(12, 71);
            btn_DineIn.Name = "btn_DineIn";
            btn_DineIn.Size = new Size(86, 36);
            btn_DineIn.TabIndex = 2;
            btn_DineIn.Text = "Dine In";
            btn_DineIn.UseVisualStyleBackColor = false;
            // 
            // btn_Togo
            // 
            btn_Togo.BackColor = Color.White;
            btn_Togo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Togo.ForeColor = Color.FromArgb(190, 30, 45);
            btn_Togo.Location = new Point(142, 71);
            btn_Togo.Name = "btn_Togo";
            btn_Togo.Size = new Size(86, 36);
            btn_Togo.TabIndex = 3;
            btn_Togo.Text = "To Go";
            btn_Togo.UseVisualStyleBackColor = false;
            // 
            // btn_Delivery
            // 
            btn_Delivery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delivery.ForeColor = Color.FromArgb(190, 30, 45);
            btn_Delivery.Location = new Point(265, 71);
            btn_Delivery.Name = "btn_Delivery";
            btn_Delivery.Size = new Size(86, 36);
            btn_Delivery.TabIndex = 4;
            btn_Delivery.Text = "Delivery";
            btn_Delivery.UseVisualStyleBackColor = true;
            // 
            // fl_Panel_Cart
            // 
            fl_Panel_Cart.BorderStyle = BorderStyle.Fixed3D;
            fl_Panel_Cart.Location = new Point(12, 113);
            fl_Panel_Cart.Name = "fl_Panel_Cart";
            fl_Panel_Cart.Size = new Size(331, 220);
            fl_Panel_Cart.TabIndex = 6;
            // 
            // btn_Trash
            // 
            btn_Trash.BackgroundImage = (Image)resources.GetObject("btn_Trash.BackgroundImage");
            btn_Trash.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Trash.ForeColor = SystemColors.Control;
            btn_Trash.Location = new Point(271, -1);
            btn_Trash.Name = "btn_Trash";
            btn_Trash.Size = new Size(55, 42);
            btn_Trash.TabIndex = 9;
            btn_Trash.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_vouccher);
            panel1.Controls.Add(btn_Trash);
            panel1.Location = new Point(12, 339);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 42);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 41);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txt_vouccher
            // 
            txt_vouccher.AccessibleName = "";
            txt_vouccher.BackColor = SystemColors.Control;
            txt_vouccher.BorderStyle = BorderStyle.None;
            txt_vouccher.Location = new Point(-1, -1);
            txt_vouccher.Multiline = true;
            txt_vouccher.Name = "txt_vouccher";
            txt_vouccher.Size = new Size(266, 41);
            txt_vouccher.TabIndex = 11;
            txt_vouccher.Tag = "";
            txt_vouccher.TextAlign = HorizontalAlignment.Center;
            // 
            // panel_Cart_footer
            // 
            panel_Cart_footer.BackColor = Color.White;
            panel_Cart_footer.BorderStyle = BorderStyle.Fixed3D;
            panel_Cart_footer.Controls.Add(panel3);
            panel_Cart_footer.Controls.Add(panel2);
            panel_Cart_footer.Location = new Point(12, 387);
            panel_Cart_footer.Name = "panel_Cart_footer";
            panel_Cart_footer.Size = new Size(331, 227);
            panel_Cart_footer.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btn_SenOrder);
            panel3.Controls.Add(btn_CancelOrder);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 111);
            panel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 11);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 1;
            label6.Text = "TOTAL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 11);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 2;
            label7.Text = "label7";
            // 
            // btn_SenOrder
            // 
            btn_SenOrder.BackgroundImage = (Image)resources.GetObject("btn_SenOrder.BackgroundImage");
            btn_SenOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btn_SenOrder.Location = new Point(180, 51);
            btn_SenOrder.Name = "btn_SenOrder";
            btn_SenOrder.Size = new Size(98, 46);
            btn_SenOrder.TabIndex = 4;
            btn_SenOrder.UseVisualStyleBackColor = true;
            // 
            // btn_CancelOrder
            // 
            btn_CancelOrder.BackgroundImage = (Image)resources.GetObject("btn_CancelOrder.BackgroundImage");
            btn_CancelOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btn_CancelOrder.Location = new Point(16, 52);
            btn_CancelOrder.Name = "btn_CancelOrder";
            btn_CancelOrder.Size = new Size(98, 45);
            btn_CancelOrder.TabIndex = 3;
            btn_CancelOrder.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-2, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 106);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 57);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 4;
            label8.Text = "10%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 61);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 17);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 57);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 1;
            label3.Text = "DISCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 14);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 0;
            label2.Text = "SUBTOTATAL";
            // 
            // uc_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Cart_footer);
            Controls.Add(panel1);
            Controls.Add(fl_Panel_Cart);
            Controls.Add(btn_Delivery);
            Controls.Add(btn_Togo);
            Controls.Add(btn_DineIn);
            Controls.Add(txt_id);
            Controls.Add(label1);
            Name = "uc_Order";
            Size = new Size(354, 617);
            Load += uc_Order_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Cart_footer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txt_id;
        private Button btn_DineIn;
        private Button btn_Togo;
        private Button btn_Delivery;
        private FlowLayoutPanel fl_Panel_Cart;
        private Button btn_Trash;
        private Panel panel1;
        private TextBox txt_vouccher;
        private PictureBox pictureBox1;
        private Panel panel_Cart_footer;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Button btn_SenOrder;
        private Button btn_CancelOrder;
        private Panel panel2;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
