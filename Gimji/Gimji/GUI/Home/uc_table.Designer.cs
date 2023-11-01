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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_table));
            btn_table = new Button();
            SuspendLayout();
            // 
            // btn_table
            // 
            btn_table.BackgroundImage = (Image)resources.GetObject("btn_table.BackgroundImage");
            btn_table.BackgroundImageLayout = ImageLayout.Stretch;
            btn_table.FlatAppearance.BorderSize = 0;
            btn_table.FlatStyle = FlatStyle.Flat;
            btn_table.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_table.Location = new Point(32, 42);
            btn_table.Name = "btn_table";
            btn_table.Size = new Size(200, 200);
            btn_table.TabIndex = 1;
            btn_table.Text = "ID";
            btn_table.UseVisualStyleBackColor = true;
            btn_table.Click += btn_table_Click;
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

        private Button btn_table;
    }
}
