namespace ShopAppBD
{
    partial class AddModifyEmployeeForm
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
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.hiredateBox = new System.Windows.Forms.TextBox();
            this.hiredateLabel = new System.Windows.Forms.Label();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(12, 234);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(207, 22);
            this.salaryBox.TabIndex = 19;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(12, 214);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(51, 17);
            this.salaryLabel.TabIndex = 18;
            this.salaryLabel.Text = "Pensja";
            // 
            // hiredateBox
            // 
            this.hiredateBox.Location = new System.Drawing.Point(12, 181);
            this.hiredateBox.Name = "hiredateBox";
            this.hiredateBox.Size = new System.Drawing.Size(207, 22);
            this.hiredateBox.TabIndex = 17;
            this.hiredateBox.Text = "[MM/DD/RRRR]";
            // 
            // hiredateLabel
            // 
            this.hiredateLabel.AutoSize = true;
            this.hiredateLabel.Location = new System.Drawing.Point(12, 161);
            this.hiredateLabel.Name = "hiredateLabel";
            this.hiredateLabel.Size = new System.Drawing.Size(120, 17);
            this.hiredateLabel.TabIndex = 16;
            this.hiredateLabel.Text = "Data zatrudnienia";
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(12, 130);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(207, 22);
            this.positionBox.TabIndex = 15;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(12, 110);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(79, 17);
            this.positionLabel.TabIndex = 14;
            this.positionLabel.Text = "Stanowisko";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(12, 76);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(207, 22);
            this.surnameBox.TabIndex = 13;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 56);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(67, 17);
            this.surnameLabel.TabIndex = 12;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(207, 22);
            this.nameBox.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 17);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Imię";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 291);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(207, 22);
            this.passwordBox.TabIndex = 21;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 271);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(44, 17);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Hasło";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "[Pozostaw puste jeżeli bez zmian]";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(239, 12);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(85, 45);
            this.confirmButton.TabIndex = 23;
            this.confirmButton.Text = "Potwierdź";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(239, 63);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 45);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddModifyEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 340);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.hiredateBox);
            this.Controls.Add(this.hiredateLabel);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.Name = "AddModifyEmployeeForm";
            this.Text = "AddModifyEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox hiredateBox;
        private System.Windows.Forms.Label hiredateLabel;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}