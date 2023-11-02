namespace Gimji.GUI.Management.StaffManagement
{
    partial class uc_staff
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_staff));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna_pal_staff = new Guna.UI2.WinForms.Guna2Panel();
            guna_btn_remove = new Guna.UI2.WinForms.Guna2Button();
            guna_btn_edit = new Guna.UI2.WinForms.Guna2Button();
            lb_position = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_stt = new Label();
            guna_pal_staff.SuspendLayout();
            SuspendLayout();
            // 
            // guna_pal_staff
            // 
            guna_pal_staff.BackColor = Color.Transparent;
            guna_pal_staff.BorderColor = Color.FromArgb(224, 224, 224);
            guna_pal_staff.BorderRadius = 5;
            guna_pal_staff.BorderThickness = 1;
            guna_pal_staff.Controls.Add(guna_btn_remove);
            guna_pal_staff.Controls.Add(guna_btn_edit);
            guna_pal_staff.Controls.Add(lb_position);
            guna_pal_staff.Controls.Add(lb_name);
            guna_pal_staff.Controls.Add(lb_id);
            guna_pal_staff.Controls.Add(lb_stt);
            guna_pal_staff.CustomizableEdges = customizableEdges5;
            guna_pal_staff.Location = new Point(0, 0);
            guna_pal_staff.Name = "guna_pal_staff";
            guna_pal_staff.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna_pal_staff.Size = new Size(546, 37);
            guna_pal_staff.TabIndex = 2;
            guna_pal_staff.MouseEnter += guna_pal_staff_MouseEnter;
            guna_pal_staff.MouseLeave += guna_pal_staff_MouseLeave;
            // 
            // guna_btn_remove
            // 
            guna_btn_remove.BorderRadius = 5;
            guna_btn_remove.CustomizableEdges = customizableEdges1;
            guna_btn_remove.DisabledState.BorderColor = Color.DarkGray;
            guna_btn_remove.DisabledState.CustomBorderColor = Color.DarkGray;
            guna_btn_remove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna_btn_remove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna_btn_remove.FillColor = Color.Transparent;
            guna_btn_remove.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna_btn_remove.ForeColor = Color.White;
            guna_btn_remove.Image = (Image)resources.GetObject("guna_btn_remove.Image");
            guna_btn_remove.ImageSize = new Size(25, 25);
            guna_btn_remove.Location = new Point(506, 6);
            guna_btn_remove.Name = "guna_btn_remove";
            guna_btn_remove.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna_btn_remove.Size = new Size(27, 27);
            guna_btn_remove.TabIndex = 5;
            // 
            // guna_btn_edit
            // 
            guna_btn_edit.BorderRadius = 5;
            guna_btn_edit.CustomizableEdges = customizableEdges3;
            guna_btn_edit.DisabledState.BorderColor = Color.DarkGray;
            guna_btn_edit.DisabledState.CustomBorderColor = Color.DarkGray;
            guna_btn_edit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna_btn_edit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna_btn_edit.FillColor = Color.Transparent;
            guna_btn_edit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna_btn_edit.ForeColor = Color.White;
            guna_btn_edit.HoverState.BorderColor = Color.White;
            guna_btn_edit.Image = (Image)resources.GetObject("guna_btn_edit.Image");
            guna_btn_edit.ImageSize = new Size(25, 25);
            guna_btn_edit.Location = new Point(475, 6);
            guna_btn_edit.Name = "guna_btn_edit";
            guna_btn_edit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna_btn_edit.Size = new Size(27, 27);
            guna_btn_edit.TabIndex = 4;
            // 
            // lb_position
            // 
            lb_position.AutoSize = true;
            lb_position.FlatStyle = FlatStyle.Flat;
            lb_position.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_position.ForeColor = SystemColors.ButtonHighlight;
            lb_position.Location = new Point(344, 4);
            lb_position.Name = "lb_position";
            lb_position.Size = new Size(49, 28);
            lb_position.TabIndex = 3;
            lb_position.Text = "CEO";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.BackColor = Color.Transparent;
            lb_name.FlatStyle = FlatStyle.Flat;
            lb_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_name.ForeColor = SystemColors.ButtonHighlight;
            lb_name.Location = new Point(218, 4);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(96, 28);
            lb_name.TabIndex = 2;
            lb_name.Text = "Elelphant";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.FlatStyle = FlatStyle.Flat;
            lb_id.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_id.ForeColor = SystemColors.ButtonHighlight;
            lb_id.Location = new Point(102, 4);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(62, 28);
            lb_id.TabIndex = 1;
            lb_id.Text = "#1001";
            lb_id.Click += lb_id_Click;
            // 
            // lb_stt
            // 
            lb_stt.AutoSize = true;
            lb_stt.FlatStyle = FlatStyle.Flat;
            lb_stt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_stt.ForeColor = SystemColors.ButtonHighlight;
            lb_stt.Location = new Point(13, 4);
            lb_stt.Name = "lb_stt";
            lb_stt.Size = new Size(20, 28);
            lb_stt.TabIndex = 0;
            lb_stt.Text = "1";
            // 
            // uc_staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna_pal_staff);
            Name = "uc_staff";
            Size = new Size(546, 37);
            guna_pal_staff.ResumeLayout(false);
            guna_pal_staff.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna_pal_staff;
        private Guna.UI2.WinForms.Guna2Button guna_btn_edit;
        private Label lb_position;
        private Label lb_name;
        private Label lb_id;
        private Label lb_stt;
        private Guna.UI2.WinForms.Guna2Button guna_btn_remove;
    }
}
