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
    public partial class ShowRotaForm : Form
    {
        OracleConnection conn;
        User user;

        public ShowRotaForm(OracleConnection conn, User user)
        {
            this.conn = conn;
            this.user = user;

            InitializeComponent();

            OracleCommand getRota = new OracleCommand();
            getRota.Connection = conn;
            getRota.CommandText = "select EMPLOYEE_ID,DATE_TIME,HOURS from GODZINY_DO_GRAFIKU where EMPLOYEE_ID = " + user.Login;
            OracleDataReader dataReader = getRota.ExecuteReader();
            while(dataReader.Read())
            {
                string[] splittedDataTime = Convert.ToString(dataReader.GetOracleTimeStamp(1)).Split(' ');
                string[] row = { splittedDataTime[0], splittedDataTime[1], Convert.ToString(dataReader.GetDouble(2)) };
                rotaView.Items.Add(new ListViewItem(row));
            }
        }
    }
}
