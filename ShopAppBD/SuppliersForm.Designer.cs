namespace ShopAppBD
{
    partial class SuppliersForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.addSupplier = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
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
            this.suppliersView.Size = new System.Drawing.Size(309, 426);
            this.suppliersView.TabIndex = 2;
            this.suppliersView.UseCompatibleStateImageBehavior = false;
            this.suppliersView.View = System.Windows.Forms.View.Details;
            this.suppliersView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.suppliersView_ItemSelectionChanged);
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
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 443);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(270, 17);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "Wybierz dostawcę aby zobaczyć dostawy!";
            // 
            // addSupplier
            // 
            this.addSupplier.Location = new System.Drawing.Point(327, 60);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(145, 50);
            this.addSupplier.TabIndex = 4;
            this.addSupplier.Text = "Dodaj dostawce";
            this.addSupplier.UseVisualStyleBackColor = true;
            this.addSupplier.Click += new System.EventHandler(this.addSupplier_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(327, 32);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(145, 22);
            this.nameBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(327, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 17);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Nazwa";
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 469);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addSupplier);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.suppliersView);
            this.Name = "SuppliersForm";
            this.Text = "SuppliersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView suppliersView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader shipmentsColumn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button addSupplier;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
    }
}