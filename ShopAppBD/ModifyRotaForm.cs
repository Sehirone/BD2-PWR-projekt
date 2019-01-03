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
    public partial class ModifyRotaForm : Form
    {
        OracleConnection conn;

        public ModifyRotaForm(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            populateEmployeesBox();
            populateStartTimeBox();
            populateWorkHoursBox();
        }

        private void populateEmployeesBox()
        {
            OracleCommand getEmployees = new OracleCommand();
            getEmployees.Connection = conn;
            getEmployees.CommandText = "select employee_id, first_name, last_name from PRACOWNICY";
            OracleDataReader dataReader = getEmployees.ExecuteReader();
            while(dataReader.Read())
            {
                employeesBox.Items.Add(Convert.ToString(dataReader.GetInt32(0)) + ": " + dataReader.GetString(1) + " " + dataReader.GetString(2));
            }
        }

        private void populateStartTimeBox()
        {
            for(int i = 0; i < 24; i++)
            {
                startTimeBox.Items.Add(Convert.ToString(i) + ":00");
                startTimeBox.Items.Add(Convert.ToString(i) + ":30");
            }
        }

        private void populateWorkHoursBox()
        {
            for(int i = 0; i < 16; i++)
            {
                workHoursBox.Items.Add(Convert.ToString(i) + ",0");
                workHoursBox.Items.Add(Convert.ToString(i) + ",5");
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            populateView();
        }

        private void populateView()
        {
            rotaView.Items.Clear();

            OracleCommand getRota = new OracleCommand();
            getRota.Connection = conn;
            getRota.CommandText = "select PRACOWNICY.first_name, PRACOWNICY.last_name, GODZINY_DO_GRAFIKU.DATE_TIME, GODZINY_DO_GRAFIKU.HOURS, GODZINY_DO_GRAFIKU.ROTA_HOURS_ID from GODZINY_DO_GRAFIKU INNER JOIN PRACOWNICY ON GODZINY_DO_GRAFIKU.employee_id = PRACOWNICY.employee_id where GODZINY_DO_GRAFIKU.DATE_TIME >= TO_DATE('" + monthCalendar1.SelectionRange.Start.ToShortDateString() + "', 'dd.mm.yyyy') AND GODZINY_DO_GRAFIKU.DATE_TIME < TO_DATE('" + monthCalendar1.SelectionRange.Start.AddDays(1).ToShortDateString() + "', 'dd.mm.yyyy')";
            OracleDataReader dataReader = getRota.ExecuteReader();
            while (dataReader.Read())
            {
                string[] splittedDataTime = Convert.ToString(dataReader.GetOracleTimeStamp(2)).Split(' ');
                string[] row = { Convert.ToString(dataReader.GetInt32(4)), splittedDataTime[1], Convert.ToString(dataReader.GetDouble(3)), dataReader.GetString(0) + " " + dataReader.GetString(1) };
                rotaView.Items.Add(new ListViewItem(row));
            }
        }

        private void addShiftButton_Click(object sender, EventArgs e)
        {
            OracleCommand addShift = new OracleCommand();
            addShift.Connection = conn;
            addShift.CommandText = "INSERT INTO GODZINY_DO_GRAFIKU(EMPLOYEE_ID, DATE_TIME, HOURS) VALUES(" +
                                    "'" + employeesBox.SelectedItem.ToString().Split(':')[0] + "', " +
                                    "TO_DATE('" + monthCalendar1.SelectionRange.Start.ToShortDateString() + " " + startTimeBox.SelectedItem.ToString() + "', 'dd.mm.yyyy HH24:MI'), " +
                                    "'" + workHoursBox.SelectedItem.ToString() + "')";
            addShift.Parameters.Add("p1", OracleDbType.Int32).Value = Int32.Parse(employeesBox.SelectedItem.ToString().Split(':')[0]);
            addShift.Parameters.Add("p2", OracleDbType.Double).Value = Double.Parse(workHoursBox.SelectedItem.ToString());
            int updates = addShift.ExecuteNonQuery();
            populateView();
        }

        private void removeShiftButton_Click(object sender, EventArgs e)
        {
            if(rotaView.SelectedItems.Count > 0)
            {
                OracleCommand removeShift = new OracleCommand();
                removeShift.Connection = conn;
                removeShift.CommandText = "DELETE FROM GODZINY_DO_GRAFIKU WHERE ROTA_HOURS_ID = " + rotaView.SelectedItems[0].SubItems[0].Text;
                int updates = removeShift.ExecuteNonQuery();
                populateView();
            }
            
        }
    }
}
