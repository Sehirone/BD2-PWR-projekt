using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ShopAppBD
{
    public partial class AddModifyEmployeeForm : Form
    {
        OracleConnection conn;
        ListViewItem employee;

        // Constructor if creating new user
        public AddModifyEmployeeForm(OracleConnection conn)
        {
            this.conn = conn;
            employee = null;

            InitializeComponent();
        }

        // Constructor if modifying already existing one
        public AddModifyEmployeeForm(OracleConnection conn, ListViewItem employee)
        {
            this.conn = conn;
            this.employee = employee;

            InitializeComponent();

            nameBox.Text = employee.SubItems[2].Text;
            surnameBox.Text = employee.SubItems[3].Text;
            positionBox.Text = employee.SubItems[1].Text;
            hiredateBox.Text = employee.SubItems[4].Text;
            salaryBox.Text = employee.SubItems[5].Text;

        }

        // checks if data entered in boxes is correct and paints the labels with error color
        private Boolean checkDataCorrectness()
        {
            Boolean isDataCorrect = true;
            int tempIntResult,tempIntResult2,tempIntResult3;
            clearLabels();
            if (nameBox.Text == "")
            {
                nameLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if (surnameBox.Text == "")
            {
                surnameLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if (!Int32.TryParse(salaryBox.Text, out tempIntResult))
            {
                salaryLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            } else
            {
                if (tempIntResult < 0)
                {
                    salaryLabel.ForeColor = Color.Red;
                    isDataCorrect = false;
                }
            }
            if (positionBox.Text != "Kie" && positionBox.Text != "Pra" && positionBox.Text != "Man")
            {
                positionLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if (employee == null && passwordBox.Text == "")
            {
                passwordLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            string[] date = { "", "", "" };
            date = hiredateBox.Text.Split('/');
            if(date.Length == 3)
            {
                if (!Int32.TryParse(date[0], out tempIntResult) || !Int32.TryParse(date[1], out tempIntResult2) || !Int32.TryParse(date[2], out tempIntResult3))
                {
                    hiredateLabel.ForeColor = Color.Red;
                    isDataCorrect = false;
                }
                else
                {
                    if (tempIntResult > 12 || tempIntResult < 1)
                    {
                        hiredateLabel.ForeColor = Color.Red;
                        isDataCorrect = false;
                    }
                    if (tempIntResult2 > 31 || tempIntResult2 < 1)
                    {
                        hiredateLabel.ForeColor = Color.Red;
                        isDataCorrect = false;
                    }
                    if (tempIntResult3 > 9999 || tempIntResult3 < 1000)
                    {
                        hiredateLabel.ForeColor = Color.Red;
                        isDataCorrect = false;
                    }
                }
            } else
            {
                hiredateLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            
            return isDataCorrect;
        }

        // clears labels from showing error color
        private void clearLabels()
        {
            nameLabel.ForeColor = Color.Black;
            surnameLabel.ForeColor = Color.Black;
            salaryLabel.ForeColor = Color.Black;
            positionLabel.ForeColor = Color.Black;
            passwordLabel.ForeColor = Color.Black;
            hiredateLabel.ForeColor = Color.Black;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(checkDataCorrectness())
            {
                if (employee == null)
                {
                    OracleCommand addEmployee = new OracleCommand();
                    addEmployee.Connection = conn;
                    addEmployee.CommandText = "INSERT INTO PRACOWNICY (JOB_ID,FIRST_NAME,LAST_NAME,HIRE_DATE,SALARY,PASSWORD) VALUES (:p1,:p2,:p3,:p4,:p5,:p6)";
                    addEmployee.Parameters.Add("p1", OracleDbType.Varchar2).Value = positionBox.Text;
                    addEmployee.Parameters.Add("p2", OracleDbType.Varchar2).Value = nameBox.Text;
                    addEmployee.Parameters.Add("p3", OracleDbType.Varchar2).Value = surnameBox.Text;
                    addEmployee.Parameters.Add("p4", OracleDbType.Date).Value = hiredateBox.Text;
                    addEmployee.Parameters.Add("p5", OracleDbType.Int32).Value = int.Parse(salaryBox.Text);
                    addEmployee.Parameters.Add("p6", OracleDbType.Varchar2).Value = passwordBox.Text;
                    int updates = addEmployee.ExecuteNonQuery();
                    this.Close();
                }
                else
                {
                    OracleCommand modifyEmployee = new OracleCommand();
                    modifyEmployee.Connection = conn;
                    modifyEmployee.CommandText = "UPDATE PRACOWNICY SET";
                    if(nameBox.Text != employee.SubItems[2].Text)
                    {
                        modifyEmployee.CommandText += " FIRST_NAME = :name,";
                        modifyEmployee.Parameters.Add("name", OracleDbType.Varchar2).Value = nameBox.Text;
                    }
                    if(surnameBox.Text != employee.SubItems[3].Text)
                    {
                        modifyEmployee.CommandText += " LAST_NAME = :surname,";
                        modifyEmployee.Parameters.Add("surname", OracleDbType.Varchar2).Value = surnameBox.Text;
                    }
                    if(positionBox.Text != employee.SubItems[1].Text)
                    {
                        modifyEmployee.CommandText += " JOB_ID = :position,";
                        modifyEmployee.Parameters.Add("position", OracleDbType.Varchar2).Value = positionBox.Text;
                    }
                    if(hiredateBox.Text != employee.SubItems[4].Text) 
                    {
                        modifyEmployee.CommandText += " HIRE_DATE = :hiredate,";
                        modifyEmployee.Parameters.Add("hiredate", OracleDbType.Date).Value = hiredateBox.Text;
                    }
                    if(salaryBox.Text != employee.SubItems[5].Text)
                    {
                        modifyEmployee.CommandText += " SALARY = :sal,";
                        modifyEmployee.Parameters.Add("sal", OracleDbType.Int32).Value = Int32.Parse(salaryBox.Text);
                    }
                    if(passwordBox.Text != "")
                    {
                        modifyEmployee.CommandText += " PASSWORD = :pass,";
                        modifyEmployee.Parameters.Add("pass", OracleDbType.Varchar2).Value = passwordBox.Text;
                    }
                    modifyEmployee.CommandText = modifyEmployee.CommandText.Remove(modifyEmployee.CommandText.LastIndexOf(','), 1);
                    modifyEmployee.CommandText += " WHERE EMPLOYEE_ID = :eid"; 
                    modifyEmployee.Parameters.Add("eid", OracleDbType.Int32).Value = Int32.Parse(employee.SubItems[0].Text);

                    int updates = modifyEmployee.ExecuteNonQuery();
                    this.Close();
                }
            } 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
