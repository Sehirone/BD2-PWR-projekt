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
    public partial class MainForm : Form
    {
        User user;
        OracleConnection conn;
        string connectionString; 

        public MainForm(User user)
        {
            this.user = user;
            // setup connection with database
            // ******************************************************************************
            // !!! HERE should be a user with specific privilages depending on user->privilageLevel !!!
            // ******************************************************************************
            connectionString = "Data Source=DESKTOP-774776S;User Id=SYSTEM;Password=system_password;";
            conn = new OracleConnection(connectionString);
            conn.Open();
            InitializeComponent();
            setupButtonPrivilages();
            if (conn.State == ConnectionState.Open)
            {
                infoBox.Text = "Połączono z bazą użytkowników!";
            }
            else
            {
                infoBox.Text = "Brak połączenia z bazą użytkowników!";
            }
        }

        // drops database connection
        ~MainForm()
        {
            conn.Dispose();
        }

        private void reconnectButton_Click(object sender, EventArgs e)
        {
            // reconnect to database if initial connection failed
            if (conn.State == ConnectionState.Open)
            {
                infoBox.Text = "Połączenie z bazą już istnieje!";
            }
            else
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

        // enables certain buttons basend on privilages level
        private void setupButtonPrivilages()
        {
            int privilageLevel = user.GetPrivilageLevel();
            if(privilageLevel >= 1)
            {
                sellingButton.Enabled = true;
                checkProductButton.Enabled = true;
                showRotaButton.Enabled = true;
            }
            if(privilageLevel >= 2)
            {
                transactionHistButton.Enabled = true;
                addDeliveryButton.Enabled = true;
            }
            if(privilageLevel >= 3)
            {
                employeesButton.Enabled = true;
            }
        }

        private void checkProductButton_Click(object sender, EventArgs e)
        {
            CheckProductForm checkProductForm = new CheckProductForm(conn);
            checkProductForm.ShowDialog();
        }

        private void sellingButton_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm(conn);
            sellingForm.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // TO DO 
        }
    }
}
