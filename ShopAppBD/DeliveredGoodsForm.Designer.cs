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
            this.deliveriesView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeDetailsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // deliveriesView
            // 
            this.deliveriesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.dateColumn,
            this.employeeDetailsColumn,
            this.contentsColumn});
            this.deliveriesView.FullRowSelect = true;
            this.deliveriesView.GridLines = true;
            this.deliveriesView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.deliveriesView.Location = new System.Drawing.Point(12, 12);
            this.deliveriesView.MultiSelect = false;
            this.deliveriesView.Name = "deliveriesView";
            this.deliveriesView.Size = new System.Drawing.Size(776, 426);
            this.deliveriesView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.deliveriesView.TabIndex = 3;
            this.deliveriesView.UseCompatibleStateImageBehavior = false;
            this.deliveriesView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 30;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Data";
            this.dateColumn.Width = 90;
            // 
            // employeeDetailsColumn
            // 
            this.employeeDetailsColumn.Text = "Przyjmujący";
            this.employeeDetailsColumn.Width = 150;
            // 
            // contentsColumn
            // 
            this.contentsColumn.Text = "Zawartość";
            this.contentsColumn.Width = 300;
            // 
            // DeliveredGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deliveriesView);
            this.Name = "DeliveredGoodsForm";
            this.Text = "DeliveredGoodsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView deliveriesView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader employeeDetailsColumn;
        private System.Windows.Forms.ColumnHeader contentsColumn;
    }
}