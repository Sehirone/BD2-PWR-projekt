namespace ShopAppBD
{
    partial class EmployeesForm
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
            this.employeesView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surnameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hireDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salaryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addEmployee = new System.Windows.Forms.Button();
            this.modifyEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesView
            // 
            this.employeesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.jobColumn,
            this.nameColumn,
            this.surnameColumn,
            this.hireDateColumn,
            this.salaryColumn});
            this.employeesView.FullRowSelect = true;
            this.employeesView.GridLines = true;
            this.employeesView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.employeesView.Location = new System.Drawing.Point(12, 12);
            this.employeesView.MultiSelect = false;
            this.employeesView.Name = "employeesView";
            this.employeesView.Size = new System.Drawing.Size(711, 426);
            this.employeesView.TabIndex = 1;
            this.employeesView.UseCompatibleStateImageBehavior = false;
            this.employeesView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 30;
            // 
            // jobColumn
            // 
            this.jobColumn.Text = "Stanowisko";
            this.jobColumn.Width = 85;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Imię";
            this.nameColumn.Width = 90;
            // 
            // surnameColumn
            // 
            this.surnameColumn.Text = "Nazwisko";
            this.surnameColumn.Width = 100;
            // 
            // hireDateColumn
            // 
            this.hireDateColumn.Text = "Data zatrudnienia";
            this.hireDateColumn.Width = 120;
            // 
            // salaryColumn
            // 
            this.salaryColumn.Text = "Pensja";
            this.salaryColumn.Width = 70;
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(729, 12);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(93, 50);
            this.addEmployee.TabIndex = 2;
            this.addEmployee.Text = "Dodaj pracownika";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // modifyEmployee
            // 
            this.modifyEmployee.Location = new System.Drawing.Point(729, 68);
            this.modifyEmployee.Name = "modifyEmployee";
            this.modifyEmployee.Size = new System.Drawing.Size(93, 50);
            this.modifyEmployee.TabIndex = 3;
            this.modifyEmployee.Text = "Edytuj pracownika";
            this.modifyEmployee.UseVisualStyleBackColor = true;
            this.modifyEmployee.Click += new System.EventHandler(this.modifyEmployee_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.modifyEmployee);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.employeesView);
            this.MaximizeBox = false;
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView employeesView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader surnameColumn;
        private System.Windows.Forms.ColumnHeader hireDateColumn;
        private System.Windows.Forms.ColumnHeader salaryColumn;
        private System.Windows.Forms.ColumnHeader jobColumn;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button modifyEmployee;
    }
}