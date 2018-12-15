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
    // Connects to user database - provides loging in functionality 
    public partial class LoginForm : Form
    {
        User user;
        OracleConnection conn;
        // ******************************************************************************
        // !!! HERE should be a user with only SELECT pracownicy/stanowiska privilage !!!
        // ******************************************************************************
        string connectionString = "Data Source=DESKTOP-774776S;User Id=SYSTEM;Password=system_password;";

        public LoginForm(User user)
        {
            // setup connection with database
            this.user = user;
            user.IsLogged = false;
            conn = new OracleConnection(connectionString);
            conn.Open();
            InitializeComponent();
            if (conn.State == ConnectionState.Open)
            {
                infoBox.Text = "Połączono z bazą użytkowników!";
            }
            else
            {
                infoBox.Text = "Brak połączenia z bazą użytkowników!";
            }
        }

        ~LoginForm()
        {
            // drop conenction to user database
            conn.Dispose();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // tries to connect user if database connection is set -- if successful closes dialogBox
            if (conn.State == ConnectionState.Open)
            {
                user.Login = loginBox.Text;
                user.Password = passwordBox.Text;

                OracleCommand getUserCmd = new OracleCommand();
                getUserCmd.Connection = conn;
                getUserCmd.CommandText = "select EMPLOYEE_ID,PASSWORD,JOB_ID from PRACOWNICY";
                OracleDataReader dataReader = getUserCmd.ExecuteReader();

                // read through all records in PRACOWNICY
                while (dataReader.Read())
                {
                    // if user found in database, set islogged and privilage level for app
                    if (Convert.ToString(dataReader.GetInt32(0)) == user.Login && dataReader.GetString(1) == user.Password)
                    {
                        infoBox.Text = "Zalogowano Pomyślnie!";
                        user.IsLogged = true;
                        string jobId = dataReader.GetString(2);
                        OracleCommand getUserPrivilageCmd = new OracleCommand();
                        getUserPrivilageCmd.Connection = conn;
                        getUserPrivilageCmd.CommandText = "select PRIVILAGE_LEVEL from STANOWISKA where JOB_ID = \'" + jobId + '\'';
                        dataReader = getUserPrivilageCmd.ExecuteReader();
                        dataReader.Read();
                        user.PrivilageLevel = dataReader.GetInt32(0);
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    } else
                    {
                        infoBox.Text = "Dane logowania nieprawidłowe!";
                        user.IsLogged = false;
                    }
                }
            }
            else
            {
                infoBox.Text = "Brak połączenia z bazą użytkowników - logowanie niemożliwe";
            }
        }

        private void reconnectButton_Click(object sender, EventArgs e)
        {
            // reconnect to database if initial connection failed
            if (conn.State == ConnectionState.Open)
            {
                infoBox.Text = "Połączenie z bazą już istnieje!";
            } else
            {
                conn = new OracleConnection(connectionString);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    infoBox.Text = "Połączono z bazą użytkowników!";
                }
                else
                {
                    infoBox.Text = "Brak połączenia z bazą użytkowników!";
                }
            }
        }
    }
}
