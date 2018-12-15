namespace ShopAppBD
{
    partial class AddModifyProductForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pricecutBox = new System.Windows.Forms.TextBox();
            this.pricecutLabel = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nazwa";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(126, 22);
            this.nameBox.TabIndex = 1;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(12, 76);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(126, 22);
            this.priceBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 56);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 17);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Cena";
            // 
            // pricecutBox
            // 
            this.pricecutBox.Location = new System.Drawing.Point(12, 129);
            this.pricecutBox.Name = "pricecutBox";
            this.pricecutBox.Size = new System.Drawing.Size(126, 22);
            this.pricecutBox.TabIndex = 5;
            // 
            // pricecutLabel
            // 
            this.pricecutLabel.AutoSize = true;
            this.pricecutLabel.Location = new System.Drawing.Point(12, 109);
            this.pricecutLabel.Name = "pricecutLabel";
            this.pricecutLabel.Size = new System.Drawing.Size(46, 17);
            this.pricecutLabel.TabIndex = 4;
            this.pricecutLabel.Text = "Rabat";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(12, 180);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(126, 22);
            this.quantityBox.TabIndex = 7;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 160);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(36, 17);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Ilość";
            // 
            // barcodeBox
            // 
            this.barcodeBox.Location = new System.Drawing.Point(12, 233);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(126, 22);
            this.barcodeBox.TabIndex = 9;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(12, 213);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(95, 17);
            this.barcodeLabel.TabIndex = 8;
            this.barcodeLabel.Text = "Kod kreskowy";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(144, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 51);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(144, 123);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(88, 51);
            this.modifyButton.TabIndex = 11;
            this.modifyButton.Text = "Modyfikuj";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(144, 66);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 51);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Znajdź produkt";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.AutoSize = true;
            this.infoBox.ForeColor = System.Drawing.Color.Red;
            this.infoBox.Location = new System.Drawing.Point(12, 269);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(83, 17);
            this.infoBox.TabIndex = 13;
            this.infoBox.Text = "Placeholder";
            // 
            // AddModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.barcodeBox);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.pricecutBox);
            this.Controls.Add(this.pricecutLabel);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddModifyProductForm";
            this.Text = "AddModifyProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox pricecutBox;
        private System.Windows.Forms.Label pricecutLabel;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label infoBox;
    }
}