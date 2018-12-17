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
    public partial class EmployeesForm : Form
    {
        OracleConnection conn;

        public EmployeesForm(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            populateView();
        }

        private void populateView()
        {
            employeesView.Items.Clear();

            OracleCommand getEmployees = new OracleCommand();
            getEmployees.Connection = conn;
            getEmployees.CommandText = "select EMPLOYEE_ID,JOB_ID,FIRST_NAME,LAST_NAME,HIRE_DATE,SALARY from PRACOWNICY";
            OracleDataReader dataReader = getEmployees.ExecuteReader();
            while (dataReader.Read())
            {
                string[] row = { Convert.ToString(dataReader.GetInt32(0)),
                                 dataReader.GetString(1),
                                 dataReader.GetString(2),
                                 dataReader.GetString(3),
                                 (Convert.ToString(dataReader.GetOracleDate(4)).Split(' '))[0],
                                 Convert.ToString(dataReader.GetInt32(5)),
                                 };
                employeesView.Items.Add(new ListViewItem(row));
            }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            AddModifyEmployeeForm addModifyEmployeeForm = new AddModifyEmployeeForm(conn);
            addModifyEmployeeForm.ShowDialog();
            populateView();
        }

        private void modifyEmployee_Click(object sender, EventArgs e)
        {
            if(employeesView.SelectedItems.Count > 0)
            {
                AddModifyEmployeeForm addModifyEmployeeForm = new AddModifyEmployeeForm(conn, (ListViewItem)employeesView.SelectedItems[0].Clone());
                addModifyEmployeeForm.ShowDialog();
                populateView();
            }
        }
    }
}
