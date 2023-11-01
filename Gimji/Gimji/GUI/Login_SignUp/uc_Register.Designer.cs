namespace Gimji.GUI.Login_SignUp
{
    partial class uc_Register
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
            panel_register = new Panel();
            radioButton_accept_register = new RadioButton();
            button_register_register = new Button();
            panel_confirmpass = new Panel();
            textBox_confirmpass = new TextBox();
            label_confirmpass = new Label();
            panel_createpass = new Panel();
            textBox_createpass = new TextBox();
            label_createpass = new Label();
            panel_username_register = new Panel();
            textBox_username_register = new TextBox();
            label_username_register = new Label();
            panel_register.SuspendLayout();
            panel_confirmpass.SuspendLayout();
            panel_createpass.SuspendLayout();
            panel_username_register.SuspendLayout();
            SuspendLayout();
            // 
            // panel_register
            // 
            panel_register.Controls.Add(radioButton_accept_register);
            panel_register.Controls.Add(button_register_register);
            panel_register.Controls.Add(panel_confirmpass);
            panel_register.Controls.Add(label_confirmpass);
            panel_register.Controls.Add(panel_createpass);
            panel_register.Controls.Add(label_createpass);
            panel_register.Controls.Add(panel_username_register);
            panel_register.Controls.Add(label_username_register);
            panel_register.Location = new Point(3, 3);
            panel_register.Name = "panel_register";
            panel_register.Size = new Size(338, 332);
            panel_register.TabIndex = 8;
            // 
            // radioButton_accept_register
            // 
            radioButton_accept_register.AutoSize = true;
            radioButton_accept_register.ForeColor = Color.FromArgb(233, 214, 147);
            radioButton_accept_register.Location = new Point(8, 231);
            radioButton_accept_register.Name = "radioButton_accept_register";
            radioButton_accept_register.Size = new Size(272, 24);
            radioButton_accept_register.TabIndex = 7;
            radioButton_accept_register.TabStop = true;
            radioButton_accept_register.Text = "I accept the terms and privacy policy";
            radioButton_accept_register.UseVisualStyleBackColor = true;
            // 
            // button_register_register
            // 
            button_register_register.BackColor = Color.FromArgb(151, 118, 68);
            button_register_register.FlatAppearance.BorderSize = 0;
            button_register_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 0);
            button_register_register.FlatStyle = FlatStyle.Flat;
            button_register_register.ForeColor = Color.FromArgb(248, 237, 221);
            button_register_register.Location = new Point(152, 261);
            button_register_register.Name = "button_register_register";
            button_register_register.Size = new Size(146, 32);
            button_register_register.TabIndex = 6;
            button_register_register.Text = "Register";
            button_register_register.UseVisualStyleBackColor = false;
            button_register_register.Click += button_register_register_Click;
            // 
            // panel_confirmpass
            // 
            panel_confirmpass.BackColor = SystemColors.Window;
            panel_confirmpass.Controls.Add(textBox_confirmpass);
            panel_confirmpass.Location = new Point(8, 180);
            panel_confirmpass.Name = "panel_confirmpass";
            panel_confirmpass.Size = new Size(290, 45);
            panel_confirmpass.TabIndex = 5;
            // 
            // textBox_confirmpass
            // 
            textBox_confirmpass.BorderStyle = BorderStyle.None;
            textBox_confirmpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_confirmpass.Location = new Point(3, 11);
            textBox_confirmpass.Name = "textBox_confirmpass";
            textBox_confirmpass.Size = new Size(287, 23);
            textBox_confirmpass.TabIndex = 1;
            textBox_confirmpass.UseSystemPasswordChar = true;
            // 
            // label_confirmpass
            // 
            label_confirmpass.AutoSize = true;
            label_confirmpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_confirmpass.ForeColor = Color.FromArgb(233, 214, 147);
            label_confirmpass.Location = new Point(3, 152);
            label_confirmpass.Name = "label_confirmpass";
            label_confirmpass.Size = new Size(157, 23);
            label_confirmpass.TabIndex = 4;
            label_confirmpass.Text = "Confirm password";
            // 
            // panel_createpass
            // 
            panel_createpass.BackColor = SystemColors.Window;
            panel_createpass.Controls.Add(textBox_createpass);
            panel_createpass.Location = new Point(8, 104);
            panel_createpass.Name = "panel_createpass";
            panel_createpass.Size = new Size(290, 45);
            panel_createpass.TabIndex = 3;
            // 
            // textBox_createpass
            // 
            textBox_createpass.BorderStyle = BorderStyle.None;
            textBox_createpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_createpass.Location = new Point(3, 11);
            textBox_createpass.Name = "textBox_createpass";
            textBox_createpass.Size = new Size(287, 23);
            textBox_createpass.TabIndex = 1;
            textBox_createpass.UseSystemPasswordChar = true;
            // 
            // label_createpass
            // 
            label_createpass.AutoSize = true;
            label_createpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_createpass.ForeColor = Color.FromArgb(233, 214, 147);
            label_createpass.Location = new Point(3, 76);
            label_createpass.Name = "label_createpass";
            label_createpass.Size = new Size(143, 23);
            label_createpass.TabIndex = 2;
            label_createpass.Text = "Create password";
            // 
            // panel_username_register
            // 
            panel_username_register.BackColor = SystemColors.Window;
            panel_username_register.Controls.Add(textBox_username_register);
            panel_username_register.Location = new Point(8, 28);
            panel_username_register.Name = "panel_username_register";
            panel_username_register.Size = new Size(290, 45);
            panel_username_register.TabIndex = 1;
            // 
            // textBox_username_register
            // 
            textBox_username_register.BorderStyle = BorderStyle.None;
            textBox_username_register.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_username_register.Location = new Point(3, 11);
            textBox_username_register.Name = "textBox_username_register";
            textBox_username_register.Size = new Size(287, 23);
            textBox_username_register.TabIndex = 0;
            // 
            // label_username_register
            // 
            label_username_register.AutoSize = true;
            label_username_register.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_username_register.ForeColor = Color.FromArgb(233, 214, 147);
            label_username_register.Location = new Point(3, 0);
            label_username_register.Name = "label_username_register";
            label_username_register.Size = new Size(89, 23);
            label_username_register.TabIndex = 0;
            label_username_register.Text = "Username";
            // 
            // uc_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_register);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_Register";
            Size = new Size(342, 335);
            panel_register.ResumeLayout(false);
            panel_register.PerformLayout();
            panel_confirmpass.ResumeLayout(false);
            panel_confirmpass.PerformLayout();
            panel_createpass.ResumeLayout(false);
            panel_createpass.PerformLayout();
            panel_username_register.ResumeLayout(false);
            panel_username_register.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_register;
        private RadioButton radioButton_accept_register;
        private Button button_register_register;
        private Panel panel_confirmpass;
        private TextBox textBox_confirmpass;
        private Label label_confirmpass;
        private Panel panel_createpass;
        private TextBox textBox_createpass;
        private Label label_createpass;
        private Panel panel_username_register;
        private TextBox textBox_username_register;
        private Label label_username_register;
    }
}
