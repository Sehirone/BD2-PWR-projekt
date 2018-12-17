namespace ShopAppBD
{
    partial class ShowRotaForm
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
            this.rotaView = new System.Windows.Forms.ListView();
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hourColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoursColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // rotaView
            // 
            this.rotaView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumn,
            this.hourColumn,
            this.hoursColumn});
            this.rotaView.FullRowSelect = true;
            this.rotaView.GridLines = true;
            this.rotaView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.rotaView.Location = new System.Drawing.Point(9, 12);
            this.rotaView.Name = "rotaView";
            this.rotaView.Size = new System.Drawing.Size(390, 426);
            this.rotaView.TabIndex = 0;
            this.rotaView.UseCompatibleStateImageBehavior = false;
            this.rotaView.View = System.Windows.Forms.View.Details;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Data";
            this.dateColumn.Width = 90;
            // 
            // hourColumn
            // 
            this.hourColumn.Text = "Godzina";
            this.hourColumn.Width = 80;
            // 
            // hoursColumn
            // 
            this.hoursColumn.Text = "Ilość godzin";
            this.hoursColumn.Width = 100;
            // 
            // ShowRotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.rotaView);
            this.Name = "ShowRotaForm";
            this.Text = "ShowRota";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView rotaView;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader hourColumn;
        private System.Windows.Forms.ColumnHeader hoursColumn;
    }
}