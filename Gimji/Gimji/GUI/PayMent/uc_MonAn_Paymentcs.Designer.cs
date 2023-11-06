namespace Gimji.GUI.PayMent
{
    partial class uc_MonAn_Paymentcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_MonAn_Paymentcs));
            pictureBox_thucDon = new PictureBox();
            txt_DishName = new Label();
            lbl_DishQuanity = new Label();
            lbl_DishPrice = new Label();
            lbl_Amount = new Label();
            btn_Trash_Payment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_thucDon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_thucDon
            // 
            pictureBox_thucDon.BackgroundImage = (Image)resources.GetObject("pictureBox_thucDon.BackgroundImage");
            pictureBox_thucDon.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_thucDon.Location = new Point(30, 0);
            pictureBox_thucDon.Margin = new Padding(3, 4, 3, 4);
            pictureBox_thucDon.Name = "pictureBox_thucDon";
            pictureBox_thucDon.Size = new Size(82, 101);
            pictureBox_thucDon.TabIndex = 0;
            pictureBox_thucDon.TabStop = false;
            // 
            // txt_DishName
            // 
            txt_DishName.AutoSize = true;
            txt_DishName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DishName.ForeColor = Color.FromArgb(255, 180, 79);
            txt_DishName.Location = new Point(119, 33);
            txt_DishName.Name = "txt_DishName";
            txt_DishName.Size = new Size(65, 28);
            txt_DishName.TabIndex = 1;
            txt_DishName.Text = "label1";
            // 
            // lbl_DishQuanity
            // 
            lbl_DishQuanity.AutoSize = true;
            lbl_DishQuanity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DishQuanity.ForeColor = Color.FromArgb(255, 180, 79);
            lbl_DishQuanity.Location = new Point(430, 33);
            lbl_DishQuanity.Name = "lbl_DishQuanity";
            lbl_DishQuanity.Size = new Size(65, 28);
            lbl_DishQuanity.TabIndex = 3;
            lbl_DishQuanity.Text = "label1";
            // 
            // lbl_DishPrice
            // 
            lbl_DishPrice.AutoSize = true;
            lbl_DishPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DishPrice.ForeColor = Color.FromArgb(255, 180, 79);
            lbl_DishPrice.Location = new Point(219, 33);
            lbl_DishPrice.Name = "lbl_DishPrice";
            lbl_DishPrice.Size = new Size(65, 28);
            lbl_DishPrice.TabIndex = 4;
            lbl_DishPrice.Text = "label1";
            // 
            // lbl_Amount
            // 
            lbl_Amount.AutoSize = true;
            lbl_Amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Amount.ForeColor = Color.FromArgb(255, 180, 79);
            lbl_Amount.Location = new Point(696, 33);
            lbl_Amount.Name = "lbl_Amount";
            lbl_Amount.Size = new Size(65, 28);
            lbl_Amount.TabIndex = 5;
            lbl_Amount.Text = "label1";
            // 
            // btn_Trash_Payment
            // 
            btn_Trash_Payment.BackgroundImage = (Image)resources.GetObject("btn_Trash_Payment.BackgroundImage");
            btn_Trash_Payment.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Trash_Payment.Location = new Point(792, 29);
            btn_Trash_Payment.Margin = new Padding(3, 4, 3, 4);
            btn_Trash_Payment.Name = "btn_Trash_Payment";
            btn_Trash_Payment.Size = new Size(41, 52);
            btn_Trash_Payment.TabIndex = 6;
            btn_Trash_Payment.UseVisualStyleBackColor = true;
            // 
            // uc_MonAn_Paymentcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 24, 24);
            Controls.Add(btn_Trash_Payment);
            Controls.Add(lbl_Amount);
            Controls.Add(lbl_DishPrice);
            Controls.Add(lbl_DishQuanity);
            Controls.Add(txt_DishName);
            Controls.Add(pictureBox_thucDon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_MonAn_Paymentcs";
            Size = new Size(925, 105);
            ((System.ComponentModel.ISupportInitialize)pictureBox_thucDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_thucDon;
        private Label txt_DishName;
        private Label lbl_DishQuanity;
        private Label lbl_DishPrice;
        private Label lbl_Amount;
        private Button btn_Trash_Payment;
    }
}
