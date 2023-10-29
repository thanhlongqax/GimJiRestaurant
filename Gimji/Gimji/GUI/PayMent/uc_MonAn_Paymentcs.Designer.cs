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
            txt_Item_Payment = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Trash_Payment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_thucDon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_thucDon
            // 
            pictureBox_thucDon.BackgroundImage = (Image)resources.GetObject("pictureBox_thucDon.BackgroundImage");
            pictureBox_thucDon.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_thucDon.Location = new Point(26, 0);
            pictureBox_thucDon.Name = "pictureBox_thucDon";
            pictureBox_thucDon.Size = new Size(72, 76);
            pictureBox_thucDon.TabIndex = 0;
            pictureBox_thucDon.TabStop = false;
            // 
            // txt_Item_Payment
            // 
            txt_Item_Payment.AutoSize = true;
            txt_Item_Payment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Item_Payment.ForeColor = Color.FromArgb(255, 180, 79);
            txt_Item_Payment.Location = new Point(104, 25);
            txt_Item_Payment.Name = "txt_Item_Payment";
            txt_Item_Payment.Size = new Size(52, 21);
            txt_Item_Payment.TabIndex = 1;
            txt_Item_Payment.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 180, 79);
            label1.Location = new Point(376, 25);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 180, 79);
            label2.Location = new Point(192, 25);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 4;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 180, 79);
            label3.Location = new Point(609, 25);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 5;
            label3.Text = "label1";
            // 
            // btn_Trash_Payment
            // 
            btn_Trash_Payment.BackgroundImage = (Image)resources.GetObject("btn_Trash_Payment.BackgroundImage");
            btn_Trash_Payment.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Trash_Payment.Location = new Point(693, 22);
            btn_Trash_Payment.Name = "btn_Trash_Payment";
            btn_Trash_Payment.Size = new Size(36, 39);
            btn_Trash_Payment.TabIndex = 6;
            btn_Trash_Payment.UseVisualStyleBackColor = true;
            // 
            // uc_MonAn_Paymentcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 24, 24);
            Controls.Add(btn_Trash_Payment);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Item_Payment);
            Controls.Add(pictureBox_thucDon);
            Name = "uc_MonAn_Paymentcs";
            Size = new Size(809, 79);
            ((System.ComponentModel.ISupportInitialize)pictureBox_thucDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_thucDon;
        private Label txt_Item_Payment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Trash_Payment;
    }
}
