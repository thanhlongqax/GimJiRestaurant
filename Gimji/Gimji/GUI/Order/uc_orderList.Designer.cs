namespace Gimji.GUI.Order
{
    partial class uc_orderList
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_orderList));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pal_order = new Guna.UI2.WinForms.Guna2Panel();
            lbl_customerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_customer_input = new Guna.UI2.WinForms.Guna2TextBox();
            lb_Status = new Label();
            lb_total = new Label();
            lb_date = new Label();
            btn_edit_Staff = new Guna.UI2.WinForms.Guna2Button();
            lb_id = new Label();
            pal_order.SuspendLayout();
            SuspendLayout();
            // 
            // pal_order
            // 
            pal_order.Controls.Add(lbl_customerName);
            pal_order.Controls.Add(lb_customer_input);
            pal_order.Controls.Add(lb_Status);
            pal_order.Controls.Add(lb_total);
            pal_order.Controls.Add(lb_date);
            pal_order.Controls.Add(btn_edit_Staff);
            pal_order.Controls.Add(lb_id);
            pal_order.CustomizableEdges = customizableEdges11;
            pal_order.Location = new Point(0, 0);
            pal_order.Margin = new Padding(3, 2, 3, 2);
            pal_order.Name = "pal_order";
            pal_order.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pal_order.Size = new Size(779, 42);
            pal_order.TabIndex = 1;
            // 
            // lbl_customerName
            // 
            lbl_customerName.BackColor = Color.Transparent;
            lbl_customerName.Location = new Point(89, 25);
            lbl_customerName.Name = "lbl_customerName";
            lbl_customerName.Size = new Size(97, 17);
            lbl_customerName.TabIndex = 17;
            lbl_customerName.Text = "guna2HtmlLabel1";
            // 
            // lb_customer_input
            // 
            lb_customer_input.CustomizableEdges = customizableEdges7;
            lb_customer_input.DefaultText = "";
            lb_customer_input.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            lb_customer_input.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            lb_customer_input.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            lb_customer_input.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            lb_customer_input.FillColor = Color.Transparent;
            lb_customer_input.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            lb_customer_input.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_customer_input.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            lb_customer_input.Location = new Point(89, 7);
            lb_customer_input.Margin = new Padding(3, 2, 3, 2);
            lb_customer_input.Name = "lb_customer_input";
            lb_customer_input.PasswordChar = '\0';
            lb_customer_input.PlaceholderText = "";
            lb_customer_input.SelectedText = "";
            lb_customer_input.ShadowDecoration.CustomizableEdges = customizableEdges8;
            lb_customer_input.Size = new Size(116, 26);
            lb_customer_input.TabIndex = 16;
            // 
            // lb_Status
            // 
            lb_Status.AutoSize = true;
            lb_Status.FlatStyle = FlatStyle.Flat;
            lb_Status.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Status.ForeColor = Color.FromArgb(80, 209, 170);
            lb_Status.Location = new Point(538, 10);
            lb_Status.Name = "lb_Status";
            lb_Status.Size = new Size(77, 19);
            lb_Status.TabIndex = 15;
            lb_Status.Text = "Completed";
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.FlatStyle = FlatStyle.Flat;
            lb_total.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_total.ForeColor = SystemColors.ButtonHighlight;
            lb_total.Location = new Point(414, 10);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(58, 19);
            lb_total.TabIndex = 14;
            lb_total.Text = "125.000";
            lb_total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.FlatStyle = FlatStyle.Flat;
            lb_date.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_date.ForeColor = SystemColors.ButtonHighlight;
            lb_date.Location = new Point(250, 10);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(73, 19);
            lb_date.TabIndex = 13;
            lb_date.Text = "11-2-2023";
            // 
            // btn_edit_Staff
            // 
            btn_edit_Staff.BorderRadius = 5;
            btn_edit_Staff.CustomizableEdges = customizableEdges9;
            btn_edit_Staff.DisabledState.BorderColor = Color.DarkGray;
            btn_edit_Staff.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_edit_Staff.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_edit_Staff.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_edit_Staff.FillColor = Color.Transparent;
            btn_edit_Staff.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_edit_Staff.ForeColor = Color.White;
            btn_edit_Staff.HoverState.BorderColor = Color.White;
            btn_edit_Staff.Image = (Image)resources.GetObject("btn_edit_Staff.Image");
            btn_edit_Staff.ImageSize = new Size(25, 25);
            btn_edit_Staff.Location = new Point(675, 7);
            btn_edit_Staff.Margin = new Padding(3, 2, 3, 2);
            btn_edit_Staff.Name = "btn_edit_Staff";
            btn_edit_Staff.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btn_edit_Staff.Size = new Size(24, 20);
            btn_edit_Staff.TabIndex = 10;
            btn_edit_Staff.Click += btn_edit_Staff_Click;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.FlatStyle = FlatStyle.Flat;
            lb_id.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_id.ForeColor = SystemColors.ButtonHighlight;
            lb_id.Location = new Point(8, 10);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(47, 19);
            lb_id.TabIndex = 6;
            lb_id.Text = "#1234";
            // 
            // uc_orderList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pal_order);
            Margin = new Padding(3, 2, 3, 2);
            Name = "uc_orderList";
            Size = new Size(757, 42);
            pal_order.ResumeLayout(false);
            pal_order.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pal_order;
        private Label lb_Status;
        private Label lb_total;
        private Label lb_date;
        private Guna.UI2.WinForms.Guna2Button btn_edit_Staff;
        private Label lb_id;
        private Guna.UI2.WinForms.Guna2TextBox lb_customer_input;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_customerName;
    }
}
