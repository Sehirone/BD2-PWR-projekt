namespace ShopAppBD
{
    partial class SellingForm
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
            this.searchProductButton = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barcodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.totalCostBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(689, 12);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(99, 49);
            this.searchProductButton.TabIndex = 0;
            this.searchProductButton.Text = "Znajdz produkt";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
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
            this.itemsList.Location = new System.Drawing.Point(12, 12);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(671, 363);
            this.itemsList.TabIndex = 6;
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
            this.barcodeColumn.Width = 121;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(689, 67);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 49);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Usuń produkt";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(689, 346);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(99, 49);
            this.sellButton.TabIndex = 8;
            this.sellButton.Text = "Sprzedaj";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // totalCostBox
            // 
            this.totalCostBox.AutoSize = true;
            this.totalCostBox.Location = new System.Drawing.Point(12, 381);
            this.totalCostBox.Name = "totalCostBox";
            this.totalCostBox.Size = new System.Drawing.Size(105, 17);
            this.totalCostBox.TabIndex = 9;
            this.totalCostBox.Text = "Cena łącznie: 0";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.totalCostBox);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.searchProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.ListView itemsList;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.ColumnHeader discountColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader barcodeColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label totalCostBox;
    }
}