namespace Gimji
{
    partial class Login_Form
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
            panel_login = new Panel();
            button1 = new Button();
            button_fogotPassword = new Button();
            radioButton_rememberme = new RadioButton();
            panel_password = new Panel();
            textBox_password = new TextBox();
            label_password = new Label();
            panel_username = new Panel();
            textBox_username = new TextBox();
            label_username = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox_login).BeginInit();
            panel_loginregister_button.SuspendLayout();
            panel_login.SuspendLayout();
            panel_password.SuspendLayout();
            panel_username.SuspendLayout();
            panel_register.SuspendLayout();
            panel_confirmpass.SuspendLayout();
            panel_createpass.SuspendLayout();
            panel_username_register.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_login
            // 
            pictureBox_login.Image = Properties.Resources.masterchef;
            pictureBox_login.Location = new Point(12, 12);
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
            label_welcome.Location = new Point(428, 24);
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
            panel_loginregister_button.Location = new Point(415, 66);
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
            button_register.Size = new Size(122, 46);
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
            button_login.Size = new Size(117, 46);
            button_login.TabIndex = 0;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // panel_login
            // 
            panel_login.Controls.Add(button1);
            panel_login.Controls.Add(button_fogotPassword);
            panel_login.Controls.Add(radioButton_rememberme);
            panel_login.Controls.Add(panel_password);
            panel_login.Controls.Add(label_password);
            panel_login.Controls.Add(panel_username);
            panel_login.Controls.Add(label_username);
            panel_login.Location = new Point(391, 124);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(310, 295);
            panel_login.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(151, 118, 68);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(248, 237, 221);
            button1.Location = new Point(152, 220);
            button1.Name = "button1";
            button1.Size = new Size(146, 32);
            button1.TabIndex = 6;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            // 
            // button_fogotPassword
            // 
            button_fogotPassword.BackColor = Color.FromArgb(130, 0, 0);
            button_fogotPassword.BackgroundImageLayout = ImageLayout.None;
            button_fogotPassword.FlatAppearance.BorderColor = Color.FromArgb(130, 0, 0);
            button_fogotPassword.FlatAppearance.BorderSize = 0;
            button_fogotPassword.FlatStyle = FlatStyle.Flat;
            button_fogotPassword.Location = new Point(146, 177);
            button_fogotPassword.Name = "button_fogotPassword";
            button_fogotPassword.Size = new Size(152, 29);
            button_fogotPassword.TabIndex = 5;
            button_fogotPassword.Text = "Forgot password?";
            button_fogotPassword.TextImageRelation = TextImageRelation.ImageAboveText;
            button_fogotPassword.UseVisualStyleBackColor = false;
            button_fogotPassword.Click += button_fogotPassword_Click;
            // 
            // radioButton_rememberme
            // 
            radioButton_rememberme.AutoSize = true;
            radioButton_rememberme.ForeColor = Color.FromArgb(233, 214, 147);
            radioButton_rememberme.Location = new Point(15, 179);
            radioButton_rememberme.Name = "radioButton_rememberme";
            radioButton_rememberme.Size = new Size(128, 24);
            radioButton_rememberme.TabIndex = 4;
            radioButton_rememberme.TabStop = true;
            radioButton_rememberme.Text = "Remember me";
            radioButton_rememberme.UseVisualStyleBackColor = true;
            // 
            // panel_password
            // 
            panel_password.BackColor = SystemColors.Window;
            panel_password.Controls.Add(textBox_password);
            panel_password.Location = new Point(8, 120);
            panel_password.Name = "panel_password";
            panel_password.Size = new Size(290, 45);
            panel_password.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_password.Location = new Point(3, 10);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(287, 23);
            textBox_password.TabIndex = 1;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_password.ForeColor = Color.FromArgb(233, 214, 147);
            label_password.Location = new Point(8, 94);
            label_password.Name = "label_password";
            label_password.Size = new Size(85, 23);
            label_password.TabIndex = 2;
            label_password.Text = "Password";
            // 
            // panel_username
            // 
            panel_username.BackColor = SystemColors.Window;
            panel_username.Controls.Add(textBox_username);
            panel_username.Location = new Point(8, 42);
            panel_username.Name = "panel_username";
            panel_username.Size = new Size(290, 45);
            panel_username.TabIndex = 1;
            // 
            // textBox_username
            // 
            textBox_username.BorderStyle = BorderStyle.None;
            textBox_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_username.Location = new Point(3, 10);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(287, 23);
            textBox_username.TabIndex = 0;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.ForeColor = Color.FromArgb(233, 214, 147);
            label_username.Location = new Point(8, 16);
            label_username.Name = "label_username";
            label_username.Size = new Size(89, 23);
            label_username.TabIndex = 0;
            label_username.Text = "Username";
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
            panel_register.Location = new Point(391, 124);
            panel_register.Name = "panel_register";
            panel_register.Size = new Size(310, 321);
            panel_register.TabIndex = 7;
            panel_register.Visible = false;
            // 
            // radioButton_accept_register
            // 
            radioButton_accept_register.AutoSize = true;
            radioButton_accept_register.ForeColor = Color.FromArgb(233, 214, 147);
            radioButton_accept_register.Location = new Point(8, 245);
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
            button_register_register.Location = new Point(152, 275);
            button_register_register.Name = "button_register_register";
            button_register_register.Size = new Size(146, 32);
            button_register_register.TabIndex = 6;
            button_register_register.Text = "Register";
            button_register_register.UseVisualStyleBackColor = false;
            // 
            // panel_confirmpass
            // 
            panel_confirmpass.BackColor = SystemColors.Window;
            panel_confirmpass.Controls.Add(textBox_confirmpass);
            panel_confirmpass.Location = new Point(8, 194);
            panel_confirmpass.Name = "panel_confirmpass";
            panel_confirmpass.Size = new Size(290, 45);
            panel_confirmpass.TabIndex = 5;
            // 
            // textBox_confirmpass
            // 
            textBox_confirmpass.BorderStyle = BorderStyle.None;
            textBox_confirmpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_confirmpass.Location = new Point(3, 10);
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
            label_confirmpass.Location = new Point(8, 168);
            label_confirmpass.Name = "label_confirmpass";
            label_confirmpass.Size = new Size(157, 23);
            label_confirmpass.TabIndex = 4;
            label_confirmpass.Text = "Confirm password";
            // 
            // panel_createpass
            // 
            panel_createpass.BackColor = SystemColors.Window;
            panel_createpass.Controls.Add(textBox_createpass);
            panel_createpass.Location = new Point(8, 120);
            panel_createpass.Name = "panel_createpass";
            panel_createpass.Size = new Size(290, 45);
            panel_createpass.TabIndex = 3;
            // 
            // textBox_createpass
            // 
            textBox_createpass.BorderStyle = BorderStyle.None;
            textBox_createpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_createpass.Location = new Point(3, 10);
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
            label_createpass.Location = new Point(8, 94);
            label_createpass.Name = "label_createpass";
            label_createpass.Size = new Size(143, 23);
            label_createpass.TabIndex = 2;
            label_createpass.Text = "Create password";
            // 
            // panel_username_register
            // 
            panel_username_register.BackColor = SystemColors.Window;
            panel_username_register.Controls.Add(textBox_username_register);
            panel_username_register.Location = new Point(8, 42);
            panel_username_register.Name = "panel_username_register";
            panel_username_register.Size = new Size(290, 45);
            panel_username_register.TabIndex = 1;
            // 
            // textBox_username_register
            // 
            textBox_username_register.BorderStyle = BorderStyle.None;
            textBox_username_register.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_username_register.Location = new Point(3, 10);
            textBox_username_register.Name = "textBox_username_register";
            textBox_username_register.Size = new Size(287, 23);
            textBox_username_register.TabIndex = 0;
            // 
            // label_username_register
            // 
            label_username_register.AutoSize = true;
            label_username_register.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_username_register.ForeColor = Color.FromArgb(233, 214, 147);
            label_username_register.Location = new Point(8, 16);
            label_username_register.Name = "label_username_register";
            label_username_register.Size = new Size(89, 23);
            label_username_register.TabIndex = 0;
            label_username_register.Text = "Username";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 0, 0);
            ClientSize = new Size(732, 443);
            Controls.Add(panel_register);
            Controls.Add(panel_login);
            Controls.Add(panel_loginregister_button);
            Controls.Add(label_welcome);
            Controls.Add(pictureBox_login);
            Name = "Login_Form";
            Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox_login).EndInit();
            panel_loginregister_button.ResumeLayout(false);
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            panel_password.ResumeLayout(false);
            panel_password.PerformLayout();
            panel_username.ResumeLayout(false);
            panel_username.PerformLayout();
            panel_register.ResumeLayout(false);
            panel_register.PerformLayout();
            panel_confirmpass.ResumeLayout(false);
            panel_confirmpass.PerformLayout();
            panel_createpass.ResumeLayout(false);
            panel_createpass.PerformLayout();
            panel_username_register.ResumeLayout(false);
            panel_username_register.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_login;
        private Label label_welcome;
        private Panel panel_loginregister_button;
        private Button button_register;
        private Button button_login;
        private Panel panel_login;
        private Label label_username;
        private Panel panel_password;
        private TextBox textBox_password;
        private Label label_password;
        private Panel panel_username;
        private TextBox textBox_username;
        private RadioButton radioButton_rememberme;
        private Button button_fogotPassword;
        private Button button1;
        private Panel panel_register;
        private Panel panel_confirmpass;
        private TextBox textBox_confirmpass;
        private Label label_confirmpass;
        private Panel panel_createpass;
        private TextBox textBox_createpass;
        private Label label_createpass;
        private Panel panel_username_register;
        private TextBox textBox_username_register;
        private Label label_username_register;
        private Button button_register_register;
        private RadioButton radioButton_accept_register;
    }
}