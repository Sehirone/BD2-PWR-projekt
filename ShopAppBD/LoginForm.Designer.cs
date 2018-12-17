namespace ShopAppBD
{
    partial class LoginForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.Label();
            this.reconnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(119, 17);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(51, 17);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(118, 43);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(52, 17);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Hasło: ";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(122, 68);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(155, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(176, 12);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 22);
            this.loginBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(176, 40);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 22);
            this.passwordBox.TabIndex = 5;
            // 
            // infoBox
            // 
            this.infoBox.AutoSize = true;
            this.infoBox.ForeColor = System.Drawing.Color.Red;
            this.infoBox.Location = new System.Drawing.Point(12, 147);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(83, 17);
            this.infoBox.TabIndex = 6;
            this.infoBox.Text = "Placeholder";
            // 
            // reconnectButton
            // 
            this.reconnectButton.Location = new System.Drawing.Point(121, 104);
            this.reconnectButton.Name = "reconnectButton";
            this.reconnectButton.Size = new System.Drawing.Size(155, 31);
            this.reconnectButton.TabIndex = 7;
            this.reconnectButton.Text = "Połącz z bazą";
            this.reconnectButton.UseVisualStyleBackColor = true;
            this.reconnectButton.Click += new System.EventHandler(this.reconnectButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 178);
            this.Controls.Add(this.reconnectButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label infoBox;
        private System.Windows.Forms.Button reconnectButton;
    }
}