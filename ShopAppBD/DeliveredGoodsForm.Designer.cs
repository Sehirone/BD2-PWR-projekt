namespace ShopAppBD
{
    partial class DeliveredGoodsForm
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
            this.suppliersView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shipmentsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // suppliersView
            // 
            this.suppliersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn,
            this.shipmentsColumn});
            this.suppliersView.FullRowSelect = true;
            this.suppliersView.GridLines = true;
            this.suppliersView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.suppliersView.Location = new System.Drawing.Point(12, 12);
            this.suppliersView.MultiSelect = false;
            this.suppliersView.Name = "suppliersView";
            this.suppliersView.Size = new System.Drawing.Size(459, 426);
            this.suppliersView.TabIndex = 3;
            this.suppliersView.UseCompatibleStateImageBehavior = false;
            this.suppliersView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 30;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Nazwa";
            this.nameColumn.Width = 110;
            // 
            // shipmentsColumn
            // 
            this.shipmentsColumn.Text = "Ilość dostaw";
            this.shipmentsColumn.Width = 80;
            // 
            // DeliveredGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suppliersView);
            this.Name = "DeliveredGoodsForm";
            this.Text = "DeliveredGoodsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView suppliersView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader shipmentsColumn;
    }
}