﻿using System;
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
    public partial class LoginForm : Form
    {
        User user;
        OracleConnection conn;
        string oradb = "Data Source=DESKTOP-774776S;User Id=SYSTEM;Password=system_password;";

        public LoginForm(User user)
        {
            // setup connection with database
            this.user = user;
            conn = new OracleConnection(oradb); // C#
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
            conn.Dispose();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                user.SetLogin(loginBox.Text);
                user.SetPassword(passwordBox.Text);

                OracleCommand getUserCmd = new OracleCommand();
                getUserCmd.Connection = conn;
                getUserCmd.CommandText = "select EMPLOYEE_ID,PASSWORD,JOB_ID from PRACOWNICY";
                OracleDataReader dataReader = getUserCmd.ExecuteReader();

                // read through all records in PRACOWNICY
                while (dataReader.Read())
                {
                    // if user found in database, set islogged and privilage level for app
                    if (Convert.ToString(dataReader.GetInt32(0)) == user.GetLogin() && dataReader.GetString(1) == user.GetPassword())
                    {
                        infoBox.Text = "Zalogowano Pomyślnie!";
                        user.SetIsLogged(true);
                        string jobId = dataReader.GetString(2);
                        OracleCommand getUserPrivilageCmd = new OracleCommand();
                        getUserPrivilageCmd.Connection = conn;
                        getUserPrivilageCmd.CommandText = "select PRIVILAGE_LEVEL from STANOWISKA where JOB_ID = \'" + jobId + '\'';
                        dataReader = getUserPrivilageCmd.ExecuteReader();
                        dataReader.Read();
                        user.SetPrivilageLevel(dataReader.GetInt32(0));
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    } else
                    {
                        infoBox.Text = "Dane logowania nieprawidłowe!";
                        user.SetIsLogged(false);
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
                conn = new OracleConnection(oradb); // C#
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