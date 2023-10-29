namespace Gimji.GUI.Menu
{
    partial class uc_Menu
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
            panel_Header = new Panel();
            fl_Panel_Thuc_Don = new FlowLayoutPanel();
            panel_Order = new Panel();
            SuspendLayout();
            // 
            // panel_Header
            // 
            panel_Header.BorderStyle = BorderStyle.Fixed3D;
            panel_Header.Location = new Point(0, 3);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(823, 62);
            panel_Header.TabIndex = 8;
            // 
            // fl_Panel_Thuc_Don
            // 
            fl_Panel_Thuc_Don.BorderStyle = BorderStyle.Fixed3D;
            fl_Panel_Thuc_Don.Location = new Point(3, 71);
            fl_Panel_Thuc_Don.Name = "fl_Panel_Thuc_Don";
            fl_Panel_Thuc_Don.Size = new Size(823, 549);
            fl_Panel_Thuc_Don.TabIndex = 6;
            // 
            // panel_Order
            // 
            panel_Order.BorderStyle = BorderStyle.Fixed3D;
            panel_Order.Location = new Point(826, 3);
            panel_Order.Name = "panel_Order";
            panel_Order.Size = new Size(354, 617);
            panel_Order.TabIndex = 7;
            // 
            // uc_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Header);
            Controls.Add(fl_Panel_Thuc_Don);
            Controls.Add(panel_Order);
            Name = "uc_Menu";
            Size = new Size(1183, 620);
            Load += uc_Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Header;
        private FlowLayoutPanel fl_Panel_Thuc_Don;
        private Panel panel_Order;
    }
}
