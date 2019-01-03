namespace ShopAppBD
{
    partial class CheckProductForm
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
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.barCodeBox = new System.Windows.Forms.TextBox();
            this.barCodeLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barcodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(12, 29);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(233, 22);
            this.productNameBox.TabIndex = 0;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(69, 9);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(110, 17);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Nazwa produktu";
            // 
            // barCodeBox
            // 
            this.barCodeBox.Location = new System.Drawing.Point(251, 29);
            this.barCodeBox.Name = "barCodeBox";
            this.barCodeBox.Size = new System.Drawing.Size(209, 22);
            this.barCodeBox.TabIndex = 2;
            // 
            // barCodeLabel
            // 
            this.barCodeLabel.AutoSize = true;
            this.barCodeLabel.Location = new System.Drawing.Point(311, 9);
            this.barCodeLabel.Name = "barCodeLabel";
            this.barCodeLabel.Size = new System.Drawing.Size(95, 17);
            this.barCodeLabel.TabIndex = 3;
            this.barCodeLabel.Text = "Kod kreskowy";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(466, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 39);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // itemsList
            // 
            this.itemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn,
            this.priceColumn,
            this.discountColumn,
            this.quantityColumn,
            this.barcodeColumn});
            this.itemsList.FullRowSelect = true;
            this.itemsList.GridLines = true;
            this.itemsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemsList.Location = new System.Drawing.Point(12, 57);
            this.itemsList.MultiSelect = false;
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(555, 381);
            this.itemsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.itemsList.TabIndex = 5;
            this.itemsList.UseCompatibleStateImageBehavior = false;
            this.itemsList.View = System.Windows.Forms.View.Details;
            this.itemsList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.itemsList_ItemSelectionChanged);
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
            this.quantityColumn.Text = "Ilość";
            // 
            // barcodeColumn
            // 
            this.barcodeColumn.Text = "Kod kreskowy";
            this.barcodeColumn.Width = 121;
            // 
            // CheckProductForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.barCodeLabel);
            this.Controls.Add(this.barCodeBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckProductForm";
            this.Text = "CheckProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox barCodeBox;
        private System.Windows.Forms.Label barCodeLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView itemsList;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.ColumnHeader discountColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader barcodeColumn;
    }
}