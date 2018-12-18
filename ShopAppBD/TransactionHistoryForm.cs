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
    public partial class TransactionHistoryForm : Form
    {
        OracleConnection conn;

        public TransactionHistoryForm(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();

            OracleCommand getTransactions = new OracleCommand();
            getTransactions.Connection = conn;
            getTransactions.CommandText = "select SPRZEDAZE.SALE_ID,SPRZEDAZE.EMPLOYEE_ID,SPRZEDAZE.SALE_PRICE,SPRZEDAZE.SALE_DATE,PRACOWNICY.FIRST_NAME,PRACOWNICY.LAST_NAME from SPRZEDAZE INNER JOIN PRACOWNICY ON PRACOWNICY.employee_id = SPRZEDAZE.employee_id";
            OracleDataReader dataReader = getTransactions.ExecuteReader();
            while (dataReader.Read())
            {
                string[] row = { Convert.ToString(dataReader.GetInt32(0)),
                                 dataReader.GetString(4),
                                 dataReader.GetString(5),
                                 Convert.ToString(dataReader.GetDouble(2)),
                                 (Convert.ToString(dataReader.GetOracleDate(3)).Split(' '))[0]
                                 };
                purchasesList.Items.Add(new ListViewItem(row));
            }
        }

        private void purchasesList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(purchasesList.SelectedItems.Count > 0)
            {
                PurchaseDetailsForm purchaseDetailsForm = new PurchaseDetailsForm(conn, purchasesList.SelectedItems[0].SubItems[0].Text);
                purchaseDetailsForm.ShowDialog();
            }
        }
    }
}
