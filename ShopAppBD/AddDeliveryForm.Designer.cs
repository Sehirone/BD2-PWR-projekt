namespace ShopAppBD
{
    partial class AddDeliveryForm
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
            this.itemsList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barcodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arrivedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchProductButton = new System.Windows.Forms.Button();
            this.addDeliveryButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.setQuantityButton = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.Label();
            this.suppliersBox = new System.Windows.Forms.ComboBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsList
            // 
            this.itemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn,
            this.priceColumn,
            this.discountColumn,
            this.quantityColumn,
            this.barcodeColumn,
            this.arrivedColumn});
            this.itemsList.FullRowSelect = true;
            this.itemsList.GridLines = true;
            this.itemsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemsList.HideSelection = false;
            this.itemsList.Location = new System.Drawing.Point(12, 12);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(671, 363);
            this.itemsList.TabIndex = 12;
            this.itemsList.UseCompatibleStateImageBehavior = false;
            this.itemsList.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            this.idColumn.Width = 35;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Nazwa";
            this.nameColumn.Width = 90;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Cena";
            this.priceColumn.Width = 50;
            // 
            // discountColumn
            // 
            this.discountColumn.Text = "Rabat";
            this.discountColumn.Width = 50;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Dostępne";
            // 
            // barcodeColumn
            // 
            this.barcodeColumn.Text = "Kod kreskowy";
            this.barcodeColumn.Width = 90;
            // 
            // arrivedColumn
            // 
            this.arrivedColumn.Text = "Ilość w dostawie";
            this.arrivedColumn.Width = 90;
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(689, 12);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(99, 49);
            this.searchProductButton.TabIndex = 11;
            this.searchProductButton.Text = "Znajdz produkt";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // addDeliveryButton
            // 
            this.addDeliveryButton.Location = new System.Drawing.Point(689, 326);
            this.addDeliveryButton.Name = "addDeliveryButton";
            this.addDeliveryButton.Size = new System.Drawing.Size(99, 49);
            this.addDeliveryButton.TabIndex = 14;
            this.addDeliveryButton.Text = "Dodaj";
            this.addDeliveryButton.UseVisualStyleBackColor = true;
            this.addDeliveryButton.Click += new System.EventHandler(this.addDeliveryButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(689, 67);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 49);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Usuń produkt";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // setQuantityButton
            // 
            this.setQuantityButton.Location = new System.Drawing.Point(689, 198);
            this.setQuantityButton.Name = "setQuantityButton";
            this.setQuantityButton.Size = new System.Drawing.Size(99, 23);
            this.setQuantityButton.TabIndex = 15;
            this.setQuantityButton.Text = "Ustaw";
            this.setQuantityButton.UseVisualStyleBackColor = true;
            this.setQuantityButton.Click += new System.EventHandler(this.setQuantityButton_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(689, 170);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(99, 22);
            this.quantityBox.TabIndex = 16;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(689, 150);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(36, 17);
            this.quantityLabel.TabIndex = 17;
            this.quantityLabel.Text = "Ilość";
            // 
            // infoBox
            // 
            this.infoBox.AutoSize = true;
            this.infoBox.ForeColor = System.Drawing.Color.Red;
            this.infoBox.Location = new System.Drawing.Point(12, 386);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(83, 17);
            this.infoBox.TabIndex = 18;
            this.infoBox.Text = "Placeholder";
            // 
            // suppliersBox
            // 
            this.suppliersBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppliersBox.FormattingEnabled = true;
            this.suppliersBox.Location = new System.Drawing.Point(632, 381);
            this.suppliersBox.Name = "suppliersBox";
            this.suppliersBox.Size = new System.Drawing.Size(156, 24);
            this.suppliersBox.TabIndex = 19;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(553, 386);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(73, 17);
            this.supplierLabel.TabIndex = 20;
            this.supplierLabel.Text = "Dostawca:";
            // 
            // AddDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.suppliersBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.setQuantityButton);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.searchProductButton);
            this.Controls.Add(this.addDeliveryButton);
            this.Controls.Add(this.deleteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddDeliveryForm";
            this.Text = "AddDeliveryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView itemsList;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.ColumnHeader discountColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader barcodeColumn;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.Button addDeliveryButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ColumnHeader arrivedColumn;
        private System.Windows.Forms.Button setQuantityButton;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label infoBox;
        private System.Windows.Forms.ComboBox suppliersBox;
        private System.Windows.Forms.Label supplierLabel;
    }
}