namespace WinFormsWelcomeApp
{
    partial class AuthForm
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
            txtLogin = new TextBox();
            lblLogin = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 20F);
            txtLogin.Location = new Point(90, 56);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(262, 43);
            txtLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F);
            lblLogin.Location = new Point(90, 16);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(90, 37);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 20F);
            txtPassword.Location = new Point(90, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 43);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 20F);
            lblPassword.Location = new Point(90, 128);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(134, 37);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(126, 243);
            button1.Name = "button1";
            button1.Size = new Size(179, 76);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 355);
            Controls.Add(button1);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Name = "AuthForm";
            Text = "AuthForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private Label lblLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button button1;
    }
}