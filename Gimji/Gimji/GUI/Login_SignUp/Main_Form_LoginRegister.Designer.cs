namespace Gimji
{
    partial class Main_Form_LoginRegister
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox_login = new PictureBox();
            label_welcome = new Label();
            panel_loginregister_button = new Panel();
            button_register = new Button();
            button_login = new Button();
            panel_Login_Register = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_login).BeginInit();
            panel_loginregister_button.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_login
            // 
            pictureBox_login.Image = Properties.Resources.masterchef;
            pictureBox_login.Location = new Point(11, 12);
            pictureBox_login.Name = "pictureBox_login";
            pictureBox_login.Size = new Size(325, 419);
            pictureBox_login.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_login.TabIndex = 0;
            pictureBox_login.TabStop = false;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_welcome.ForeColor = Color.FromArgb(233, 214, 147);
            label_welcome.Location = new Point(427, 24);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(215, 31);
            label_welcome.TabIndex = 1;
            label_welcome.Text = "Hi, Welcome Back!";
            // 
            // panel_loginregister_button
            // 
            panel_loginregister_button.BackColor = Color.FromArgb(248, 237, 221);
            panel_loginregister_button.Controls.Add(button_register);
            panel_loginregister_button.Controls.Add(button_login);
            panel_loginregister_button.Location = new Point(415, 67);
            panel_loginregister_button.Name = "panel_loginregister_button";
            panel_loginregister_button.Size = new Size(247, 52);
            panel_loginregister_button.TabIndex = 2;
            // 
            // button_register
            // 
            button_register.BackColor = Color.FromArgb(151, 118, 68);
            button_register.FlatAppearance.BorderSize = 0;
            button_register.FlatStyle = FlatStyle.Flat;
            button_register.ForeColor = Color.FromArgb(248, 237, 221);
            button_register.Location = new Point(122, 3);
            button_register.Name = "button_register";
            button_register.Size = new Size(122, 45);
            button_register.TabIndex = 1;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_register_Click;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(151, 118, 68);
            button_login.BackgroundImageLayout = ImageLayout.None;
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.ForeColor = Color.FromArgb(248, 237, 221);
            button_login.Location = new Point(3, 3);
            button_login.Name = "button_login";
            button_login.Size = new Size(117, 45);
            button_login.TabIndex = 0;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // panel_Login_Register
            // 
            panel_Login_Register.Location = new Point(391, 124);
            panel_Login_Register.Name = "panel_Login_Register";
            panel_Login_Register.Size = new Size(310, 317);
            panel_Login_Register.TabIndex = 3;
            // 
            // Main_Form_LoginRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 0, 0);
            ClientSize = new Size(731, 443);
            Controls.Add(panel_Login_Register);
            Controls.Add(panel_loginregister_button);
            Controls.Add(label_welcome);
            Controls.Add(pictureBox_login);
            MaximizeBox = false;
            Name = "Main_Form_LoginRegister";
            Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox_login).EndInit();
            panel_loginregister_button.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_login;
        private Label label_welcome;
        private Panel panel_loginregister_button;
        private Button button_register;
        private Button button_login;
        private Panel panel_Login_Register;
    }
}