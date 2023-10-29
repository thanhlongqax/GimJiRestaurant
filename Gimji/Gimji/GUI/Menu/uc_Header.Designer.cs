namespace Gimji.GUI.Menu
{
    partial class uc_Header
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
            panel2 = new Panel();
            btn_Salad = new Button();
            btn_Com_Tron = new Button();
            btn_Tokbokki = new Button();
            btn_KimBak = new Button();
            btn_HotDished = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btn_Salad);
            panel2.Controls.Add(btn_Com_Tron);
            panel2.Controls.Add(btn_Tokbokki);
            panel2.Controls.Add(btn_KimBak);
            panel2.Controls.Add(btn_HotDished);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 62);
            panel2.TabIndex = 3;
            // 
            // btn_Salad
            // 
            btn_Salad.Location = new Point(708, 11);
            btn_Salad.Name = "btn_Salad";
            btn_Salad.Size = new Size(87, 38);
            btn_Salad.TabIndex = 5;
            btn_Salad.Text = "SALAD";
            btn_Salad.UseVisualStyleBackColor = true;
            // 
            // btn_Com_Tron
            // 
            btn_Com_Tron.Location = new Point(346, 11);
            btn_Com_Tron.Name = "btn_Com_Tron";
            btn_Com_Tron.Size = new Size(86, 38);
            btn_Com_Tron.TabIndex = 4;
            btn_Com_Tron.Text = "CƠM TRỘN";
            btn_Com_Tron.UseVisualStyleBackColor = true;
            // 
            // btn_Tokbokki
            // 
            btn_Tokbokki.Location = new Point(529, 12);
            btn_Tokbokki.Name = "btn_Tokbokki";
            btn_Tokbokki.Size = new Size(75, 37);
            btn_Tokbokki.TabIndex = 3;
            btn_Tokbokki.Text = "TOKBOKKI";
            btn_Tokbokki.UseVisualStyleBackColor = true;
            // 
            // btn_KimBak
            // 
            btn_KimBak.Location = new Point(176, 10);
            btn_KimBak.Name = "btn_KimBak";
            btn_KimBak.Size = new Size(88, 39);
            btn_KimBak.TabIndex = 2;
            btn_KimBak.Text = "KIMBAK";
            btn_KimBak.UseVisualStyleBackColor = true;
            // 
            // btn_HotDished
            // 
            btn_HotDished.Location = new Point(13, 11);
            btn_HotDished.Name = "btn_HotDished";
            btn_HotDished.Size = new Size(101, 37);
            btn_HotDished.TabIndex = 1;
            btn_HotDished.Text = "HOT DISHED";
            btn_HotDished.UseVisualStyleBackColor = true;
            // 
            // uc_Header
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "uc_Header";
            Size = new Size(939, 63);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btn_Salad;
        private Button btn_Com_Tron;
        private Button btn_Tokbokki;
        private Button btn_KimBak;
        private Button btn_HotDished;
    }
}
