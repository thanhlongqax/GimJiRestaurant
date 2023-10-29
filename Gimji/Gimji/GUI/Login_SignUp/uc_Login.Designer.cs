namespace Gimji.GUI.Login_SignUp
{
    partial class uc_Login
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
            panel_login = new Panel();
            btn_Login = new Button();
            button_fogotPassword = new Button();
            radioButton_rememberme = new RadioButton();
            panel_password = new Panel();
            txt_password = new TextBox();
            label_password = new Label();
            panel_username = new Panel();
            txt_username = new TextBox();
            label_username = new Label();
            panel_login.SuspendLayout();
            panel_password.SuspendLayout();
            panel_username.SuspendLayout();
            SuspendLayout();
            // 
            // panel_login
            // 
            panel_login.Controls.Add(btn_Login);
            panel_login.Controls.Add(button_fogotPassword);
            panel_login.Controls.Add(radioButton_rememberme);
            panel_login.Controls.Add(panel_password);
            panel_login.Controls.Add(label_password);
            panel_login.Controls.Add(panel_username);
            panel_login.Controls.Add(label_username);
            panel_login.Location = new Point(5, 0);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(310, 295);
            panel_login.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(151, 118, 68);
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 0);
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.ForeColor = Color.FromArgb(248, 237, 221);
            btn_Login.Location = new Point(152, 220);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(146, 32);
            btn_Login.TabIndex = 6;
            btn_Login.Text = "Log in";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
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
            panel_password.Controls.Add(txt_password);
            panel_password.Location = new Point(8, 120);
            panel_password.Name = "panel_password";
            panel_password.Size = new Size(290, 45);
            panel_password.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(3, 10);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(287, 23);
            txt_password.TabIndex = 1;
            txt_password.UseSystemPasswordChar = true;
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
            panel_username.Controls.Add(txt_username);
            panel_username.Location = new Point(8, 42);
            panel_username.Name = "panel_username";
            panel_username.Size = new Size(290, 45);
            panel_username.TabIndex = 1;
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.Location = new Point(3, 10);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(287, 23);
            txt_username.TabIndex = 0;
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
            // uc_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_login);
            Margin = new Padding(3, 4, 3, 4);
            Name = "uc_Login";
            Size = new Size(321, 295);
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            panel_password.ResumeLayout(false);
            panel_password.PerformLayout();
            panel_username.ResumeLayout(false);
            panel_username.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_login;
        private Button btn_Login;
        private Button button_fogotPassword;
        private RadioButton radioButton_rememberme;
        private Panel panel_password;
        private TextBox txt_password;
        private Label label_password;
        private Panel panel_username;
        private TextBox txt_username;
        private Label label_username;
    }
}
