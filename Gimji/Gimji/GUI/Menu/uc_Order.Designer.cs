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
            label1 = new Label();
            txt_id = new Label();
            btn_DineIn = new Button();
            btn_Togo = new Button();
            btn_Delivery = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font(".VnArialH", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "ORDER";
            // 
            // txt_id
            // 
            txt_id.AutoSize = true;
            txt_id.Font = new Font(".VnArialH", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.Location = new Point(150, 35);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(0, 32);
            txt_id.TabIndex = 1;
            // 
            // btn_DineIn
            // 
            btn_DineIn.BackColor = Color.FromArgb(190, 30, 45);
            btn_DineIn.ForeColor = Color.Transparent;
            btn_DineIn.Location = new Point(14, 95);
            btn_DineIn.Margin = new Padding(3, 4, 3, 4);
            btn_DineIn.Name = "btn_DineIn";
            btn_DineIn.Size = new Size(86, 31);
            btn_DineIn.TabIndex = 2;
            btn_DineIn.Text = "Dine In";
            btn_DineIn.UseVisualStyleBackColor = false;
            // 
            // btn_Togo
            // 
            btn_Togo.Location = new Point(126, 95);
            btn_Togo.Margin = new Padding(3, 4, 3, 4);
            btn_Togo.Name = "btn_Togo";
            btn_Togo.Size = new Size(86, 31);
            btn_Togo.TabIndex = 3;
            btn_Togo.Text = "To Go";
            btn_Togo.UseVisualStyleBackColor = true;
            // 
            // btn_Delivery
            // 
            btn_Delivery.Location = new Point(246, 95);
            btn_Delivery.Margin = new Padding(3, 4, 3, 4);
            btn_Delivery.Name = "btn_Delivery";
            btn_Delivery.Size = new Size(86, 31);
            btn_Delivery.TabIndex = 4;
            btn_Delivery.Text = "Delivery";
            btn_Delivery.UseVisualStyleBackColor = true;
            // 
            // uc_Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Delivery);
            Controls.Add(btn_Togo);
            Controls.Add(btn_DineIn);
            Controls.Add(txt_id);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_Order";
            Size = new Size(373, 827);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txt_id;
        private Button btn_DineIn;
        private Button btn_Togo;
        private Button btn_Delivery;
    }
}
