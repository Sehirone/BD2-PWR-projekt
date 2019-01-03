namespace ShopAppBD
{
    partial class PurchaseDetailsForm
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
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sumColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // purchasesList
            // 
            this.purchasesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.nameColumn,
            this.priceColumn,
            this.quantityColumn,
            this.sumColumn});
            this.purchasesList.FullRowSelect = true;
            this.purchasesList.GridLines = true;
            this.purchasesList.Location = new System.Drawing.Point(12, 12);
            this.purchasesList.MultiSelect = false;
            this.purchasesList.Name = "purchasesList";
            this.purchasesList.Size = new System.Drawing.Size(455, 308);
            this.purchasesList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.purchasesList.TabIndex = 1;
            this.purchasesList.UseCompatibleStateImageBehavior = false;
            this.purchasesList.View = System.Windows.Forms.View.Details;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "ID";
            this.IdColumn.Width = 30;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Nazwa";
            this.nameColumn.Width = 100;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Cena";
            this.priceColumn.Width = 70;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Ilość";
            // 
            // sumColumn
            // 
            this.sumColumn.Text = "Suma";
            // 
            // PurchaseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 328);
            this.Controls.Add(this.purchasesList);
            this.MaximizeBox = false;
            this.Name = "PurchaseDetailsForm";
            this.Text = "PurchaseDetailsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView purchasesList;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader sumColumn;
    }
}