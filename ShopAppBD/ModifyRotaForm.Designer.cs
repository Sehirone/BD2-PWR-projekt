namespace ShopAppBD
{
    partial class ModifyRotaForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.employeesBox = new System.Windows.Forms.ComboBox();
            this.rotaView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hourColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoursColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startTimeBox = new System.Windows.Forms.ComboBox();
            this.workHoursBox = new System.Windows.Forms.ComboBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.addShiftButton = new System.Windows.Forms.Button();
            this.removeShiftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // employeesBox
            // 
            this.employeesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeesBox.FormattingEnabled = true;
            this.employeesBox.Location = new System.Drawing.Point(391, 261);
            this.employeesBox.Name = "employeesBox";
            this.employeesBox.Size = new System.Drawing.Size(198, 24);
            this.employeesBox.TabIndex = 1;
            // 
            // rotaView
            // 
            this.rotaView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.hourColumn,
            this.hoursColumn,
            this.employeeColumn});
            this.rotaView.FullRowSelect = true;
            this.rotaView.GridLines = true;
            this.rotaView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.rotaView.Location = new System.Drawing.Point(391, 18);
            this.rotaView.MultiSelect = false;
            this.rotaView.Name = "rotaView";
            this.rotaView.Size = new System.Drawing.Size(453, 203);
            this.rotaView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.rotaView.TabIndex = 2;
            this.rotaView.UseCompatibleStateImageBehavior = false;
            this.rotaView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            this.idColumn.Width = 30;
            // 
            // hourColumn
            // 
            this.hourColumn.Text = "Godzina";
            this.hourColumn.Width = 80;
            // 
            // hoursColumn
            // 
            this.hoursColumn.Text = "Ilość godzin";
            this.hoursColumn.Width = 80;
            // 
            // employeeColumn
            // 
            this.employeeColumn.Text = "Pracownik";
            this.employeeColumn.Width = 180;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Location = new System.Drawing.Point(388, 241);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(72, 17);
            this.employeeLabel.TabIndex = 3;
            this.employeeLabel.Text = "Pracownik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Początek pracy";
            // 
            // startTimeBox
            // 
            this.startTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeBox.FormattingEnabled = true;
            this.startTimeBox.Location = new System.Drawing.Point(391, 308);
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.Size = new System.Drawing.Size(102, 24);
            this.startTimeBox.TabIndex = 5;
            // 
            // workHoursBox
            // 
            this.workHoursBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workHoursBox.FormattingEnabled = true;
            this.workHoursBox.Location = new System.Drawing.Point(391, 359);
            this.workHoursBox.Name = "workHoursBox";
            this.workHoursBox.Size = new System.Drawing.Size(102, 24);
            this.workHoursBox.TabIndex = 6;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(388, 339);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(95, 17);
            this.hoursLabel.TabIndex = 7;
            this.hoursLabel.Text = "Liczba godzin";
            // 
            // addShiftButton
            // 
            this.addShiftButton.Location = new System.Drawing.Point(391, 389);
            this.addShiftButton.Name = "addShiftButton";
            this.addShiftButton.Size = new System.Drawing.Size(198, 31);
            this.addShiftButton.TabIndex = 8;
            this.addShiftButton.Text = "Dodaj zmianę";
            this.addShiftButton.UseVisualStyleBackColor = true;
            this.addShiftButton.Click += new System.EventHandler(this.addShiftButton_Click);
            // 
            // removeShiftButton
            // 
            this.removeShiftButton.Location = new System.Drawing.Point(656, 227);
            this.removeShiftButton.Name = "removeShiftButton";
            this.removeShiftButton.Size = new System.Drawing.Size(188, 31);
            this.removeShiftButton.TabIndex = 9;
            this.removeShiftButton.Text = "Usuń zaznaczoną zmianę";
            this.removeShiftButton.UseVisualStyleBackColor = true;
            this.removeShiftButton.Click += new System.EventHandler(this.removeShiftButton_Click);
            // 
            // ModifyRotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 432);
            this.Controls.Add(this.removeShiftButton);
            this.Controls.Add(this.addShiftButton);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.workHoursBox);
            this.Controls.Add(this.startTimeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.rotaView);
            this.Controls.Add(this.employeesBox);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ModifyRotaForm";
            this.Text = "ModifyRotaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox employeesBox;
        private System.Windows.Forms.ListView rotaView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader hourColumn;
        private System.Windows.Forms.ColumnHeader hoursColumn;
        private System.Windows.Forms.ColumnHeader employeeColumn;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox startTimeBox;
        private System.Windows.Forms.ComboBox workHoursBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Button addShiftButton;
        private System.Windows.Forms.Button removeShiftButton;
    }
}