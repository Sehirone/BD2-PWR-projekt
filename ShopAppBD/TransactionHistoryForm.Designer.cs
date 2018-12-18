namespace ShopAppBD
{
    partial class TransactionHistoryForm
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
            this.purchasesList = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeSurnameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salePriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // purchasesList
            // 
            this.purchasesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.employeeNameColumn,
            this.employeeSurnameColumn,
            this.salePriceColumn,
            this.dateColumn});
            this.purchasesList.FullRowSelect = true;
            this.purchasesList.GridLines = true;
            this.purchasesList.Location = new System.Drawing.Point(12, 12);
            this.purchasesList.MultiSelect = false;
            this.purchasesList.Name = "purchasesList";
            this.purchasesList.Size = new System.Drawing.Size(569, 308);
            this.purchasesList.TabIndex = 0;
            this.purchasesList.UseCompatibleStateImageBehavior = false;
            this.purchasesList.View = System.Windows.Forms.View.Details;
            this.purchasesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.purchasesList_ItemSelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "ID";
            this.IdColumn.Width = 40;
            // 
            // employeeNameColumn
            // 
            this.employeeNameColumn.Text = "Imię";
            // 
            // employeeSurnameColumn
            // 
            this.employeeSurnameColumn.Text = "Nazwisko";
            this.employeeSurnameColumn.Width = 100;
            // 
            // salePriceColumn
            // 
            this.salePriceColumn.Text = "Cena zakupu";
            this.salePriceColumn.Width = 100;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Data";
            this.dateColumn.Width = 100;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(9, 323);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(358, 17);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Wybierz sprzedaż aby zobaczyć sprzedane przedmioty!";
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 347);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.purchasesList);
            this.MaximizeBox = false;
            this.Name = "TransactionHistoryForm";
            this.Text = "TransactionHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView purchasesList;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader employeeNameColumn;
        private System.Windows.Forms.ColumnHeader employeeSurnameColumn;
        private System.Windows.Forms.ColumnHeader salePriceColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.Label infoLabel;
    }
}