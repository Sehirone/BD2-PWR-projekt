namespace ShopAppBD
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoBox = new System.Windows.Forms.Label();
            this.reconnectButton = new System.Windows.Forms.Button();
            this.sellingButton = new System.Windows.Forms.Button();
            this.transactionHistButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.checkProductButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.showRotaButton = new System.Windows.Forms.Button();
            this.addDeliveryButton = new System.Windows.Forms.Button();
            this.addModifyProductButton = new System.Windows.Forms.Button();
            this.deliveriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.AutoSize = true;
            this.infoBox.ForeColor = System.Drawing.Color.Red;
            this.infoBox.Location = new System.Drawing.Point(12, 424);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(83, 17);
            this.infoBox.TabIndex = 0;
            this.infoBox.Text = "Placeholder";
            // 
            // reconnectButton
            // 
            this.reconnectButton.Location = new System.Drawing.Point(667, 409);
            this.reconnectButton.Name = "reconnectButton";
            this.reconnectButton.Size = new System.Drawing.Size(121, 29);
            this.reconnectButton.TabIndex = 1;
            this.reconnectButton.Text = "Połącz z bazą";
            this.reconnectButton.UseVisualStyleBackColor = true;
            this.reconnectButton.Click += new System.EventHandler(this.reconnectButton_Click);
            // 
            // sellingButton
            // 
            this.sellingButton.Enabled = false;
            this.sellingButton.Location = new System.Drawing.Point(12, 12);
            this.sellingButton.Name = "sellingButton";
            this.sellingButton.Size = new System.Drawing.Size(111, 49);
            this.sellingButton.TabIndex = 2;
            this.sellingButton.Text = "Sprzedaż";
            this.sellingButton.UseVisualStyleBackColor = true;
            this.sellingButton.Click += new System.EventHandler(this.sellingButton_Click);
            // 
            // transactionHistButton
            // 
            this.transactionHistButton.Enabled = false;
            this.transactionHistButton.Location = new System.Drawing.Point(363, 12);
            this.transactionHistButton.Name = "transactionHistButton";
            this.transactionHistButton.Size = new System.Drawing.Size(111, 49);
            this.transactionHistButton.TabIndex = 3;
            this.transactionHistButton.Text = "Historia transkacji";
            this.transactionHistButton.UseVisualStyleBackColor = true;
            this.transactionHistButton.Click += new System.EventHandler(this.transactionHistButton_Click);
            // 
            // employeesButton
            // 
            this.employeesButton.Enabled = false;
            this.employeesButton.Location = new System.Drawing.Point(12, 67);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(111, 49);
            this.employeesButton.TabIndex = 4;
            this.employeesButton.Text = "Pracownicy";
            this.employeesButton.UseVisualStyleBackColor = true;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // checkProductButton
            // 
            this.checkProductButton.Enabled = false;
            this.checkProductButton.Location = new System.Drawing.Point(129, 12);
            this.checkProductButton.Name = "checkProductButton";
            this.checkProductButton.Size = new System.Drawing.Size(111, 49);
            this.checkProductButton.TabIndex = 5;
            this.checkProductButton.Text = "Sprawdź produkt";
            this.checkProductButton.UseVisualStyleBackColor = true;
            this.checkProductButton.Click += new System.EventHandler(this.checkProductButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logoutButton.Location = new System.Drawing.Point(667, 374);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(121, 29);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // showRotaButton
            // 
            this.showRotaButton.Enabled = false;
            this.showRotaButton.Location = new System.Drawing.Point(129, 67);
            this.showRotaButton.Name = "showRotaButton";
            this.showRotaButton.Size = new System.Drawing.Size(111, 49);
            this.showRotaButton.TabIndex = 7;
            this.showRotaButton.Text = "Wyświetl grafik";
            this.showRotaButton.UseVisualStyleBackColor = true;
            this.showRotaButton.Click += new System.EventHandler(this.showRotaButton_Click);
            // 
            // addDeliveryButton
            // 
            this.addDeliveryButton.Enabled = false;
            this.addDeliveryButton.Location = new System.Drawing.Point(12, 122);
            this.addDeliveryButton.Name = "addDeliveryButton";
            this.addDeliveryButton.Size = new System.Drawing.Size(111, 49);
            this.addDeliveryButton.TabIndex = 8;
            this.addDeliveryButton.Text = "Dodaj dostawe";
            this.addDeliveryButton.UseVisualStyleBackColor = true;
            this.addDeliveryButton.Click += new System.EventHandler(this.addDeliveryButton_Click);
            // 
            // addModifyProductButton
            // 
            this.addModifyProductButton.Enabled = false;
            this.addModifyProductButton.Location = new System.Drawing.Point(246, 12);
            this.addModifyProductButton.Name = "addModifyProductButton";
            this.addModifyProductButton.Size = new System.Drawing.Size(111, 49);
            this.addModifyProductButton.TabIndex = 9;
            this.addModifyProductButton.Text = "Dodaj/zmień produkt";
            this.addModifyProductButton.UseVisualStyleBackColor = true;
            this.addModifyProductButton.Click += new System.EventHandler(this.addModifyProductButton_Click);
            // 
            // deliveriesButton
            // 
            this.deliveriesButton.Enabled = false;
            this.deliveriesButton.Location = new System.Drawing.Point(129, 122);
            this.deliveriesButton.Name = "deliveriesButton";
            this.deliveriesButton.Size = new System.Drawing.Size(111, 49);
            this.deliveriesButton.TabIndex = 10;
            this.deliveriesButton.Text = "Dostawy  Dostawcy";
            this.deliveriesButton.UseVisualStyleBackColor = true;
            this.deliveriesButton.Click += new System.EventHandler(this.deliveriesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.logoutButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deliveriesButton);
            this.Controls.Add(this.addModifyProductButton);
            this.Controls.Add(this.addDeliveryButton);
            this.Controls.Add(this.showRotaButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.checkProductButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.transactionHistButton);
            this.Controls.Add(this.sellingButton);
            this.Controls.Add(this.reconnectButton);
            this.Controls.Add(this.infoBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ShopApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoBox;
        private System.Windows.Forms.Button reconnectButton;
        private System.Windows.Forms.Button sellingButton;
        private System.Windows.Forms.Button transactionHistButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button checkProductButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button showRotaButton;
        private System.Windows.Forms.Button addDeliveryButton;
        private System.Windows.Forms.Button addModifyProductButton;
        private System.Windows.Forms.Button deliveriesButton;
    }
}

