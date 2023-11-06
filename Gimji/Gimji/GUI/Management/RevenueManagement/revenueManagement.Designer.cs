namespace Gimji.GUI.Management.RevenueManagement
{
    partial class revenueManagement
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pal_button = new Guna.UI2.WinForms.Guna2Panel();
            btn_back = new Guna.UI2.WinForms.Guna2Button();
            btn_today = new Guna.UI2.WinForms.Guna2Button();
            btn_next = new Guna.UI2.WinForms.Guna2Button();
            pal_button.SuspendLayout();
            SuspendLayout();
            // 
            // pal_button
            // 
            pal_button.BackColor = Color.Transparent;
            pal_button.BorderRadius = 10;
            pal_button.Controls.Add(btn_next);
            pal_button.Controls.Add(btn_today);
            pal_button.Controls.Add(btn_back);
            pal_button.CustomizableEdges = customizableEdges7;
            pal_button.FillColor = Color.Transparent;
            pal_button.Location = new Point(28, 28);
            pal_button.Name = "pal_button";
            pal_button.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pal_button.Size = new Size(360, 54);
            pal_button.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BorderRadius = 10;
            btn_back.CustomizableEdges = customizableEdges5;
            btn_back.DisabledState.BorderColor = Color.DarkGray;
            btn_back.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_back.FillColor = Color.Transparent;
            btn_back.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = Color.FromArgb(255, 180, 79);
            btn_back.Location = new Point(0, 0);
            btn_back.Name = "btn_back";
            btn_back.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_back.Size = new Size(120, 54);
            btn_back.TabIndex = 0;
            btn_back.Text = "Back";
            // 
            // btn_today
            // 
            btn_today.BackColor = Color.Transparent;
            btn_today.CustomizableEdges = customizableEdges3;
            btn_today.DisabledState.BorderColor = Color.DarkGray;
            btn_today.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_today.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_today.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_today.FillColor = Color.Transparent;
            btn_today.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_today.ForeColor = Color.FromArgb(255, 180, 79);
            btn_today.Location = new Point(120, 0);
            btn_today.Name = "btn_today";
            btn_today.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_today.Size = new Size(119, 54);
            btn_today.TabIndex = 1;
            btn_today.Text = "Today";
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Transparent;
            btn_next.BorderRadius = 10;
            btn_next.CustomizableEdges = customizableEdges1;
            btn_next.DisabledState.BorderColor = Color.DarkGray;
            btn_next.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_next.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_next.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_next.FillColor = Color.Transparent;
            btn_next.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.ForeColor = Color.FromArgb(255, 180, 79);
            btn_next.Location = new Point(240, 0);
            btn_next.Name = "btn_next";
            btn_next.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_next.Size = new Size(120, 54);
            btn_next.TabIndex = 2;
            btn_next.Text = "Next";
            // 
            // revenueManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(136, 21, 57);
            Controls.Add(pal_button);
            Name = "revenueManagement";
            Size = new Size(1025, 724);
            pal_button.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pal_button;
        private Guna.UI2.WinForms.Guna2Button btn_next;
        private Guna.UI2.WinForms.Guna2Button btn_today;
        private Guna.UI2.WinForms.Guna2Button btn_back;
    }
}
