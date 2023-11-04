namespace Gimji.GUI.Home
{
    partial class uc_table
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_table));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_table = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btn_table
            // 
            btn_table.CustomizableEdges = customizableEdges1;
            btn_table.DisabledState.BorderColor = Color.DarkGray;
            btn_table.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_table.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_table.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_table.FillColor = Color.Transparent;
            btn_table.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_table.ForeColor = Color.FromArgb(128, 64, 0);
            btn_table.HoverState.FillColor = Color.Transparent;
            btn_table.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btn_table.Image = (Image)resources.GetObject("btn_table.Image");
            btn_table.ImageSize = new Size(180, 180);
            btn_table.Location = new Point(50, 53);
            btn_table.Name = "btn_table";
            btn_table.PressedColor = Color.Transparent;
            btn_table.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_table.Size = new Size(180, 180);
            btn_table.TabIndex = 0;
            btn_table.Text = "ID";
            btn_table.TextAlign = HorizontalAlignment.Left;
            btn_table.TextOffset = new Point(65, 0);
            // 
            // uc_table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btn_table);
            Name = "uc_table";
            Size = new Size(280, 280);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_table;
    }
}
