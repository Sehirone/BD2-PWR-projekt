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
    public partial class CheckProductForm : Form
    {
        OracleConnection conn;

        public CheckProductForm(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                itemsList.Items.Clear();

                string productName = productNameBox.Text == "" ? "*!@NOTHING TO LOOK FOR@!*" : productNameBox.Text;
                string barCode = barCodeBox.Text;

                OracleCommand getUserCmd = new OracleCommand();
                getUserCmd.Connection = conn;
                getUserCmd.CommandText = "select PRODUCT_NAME,BARCODE,PRICE,PRICE_CUT,QUANTITY from PRODUKTY WHERE BARCODE = \'" + barCode + "\' OR PRODUCT_NAME LIKE \'%" + productName + "%\'";
                OracleDataReader dataReader = getUserCmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string[] row = { dataReader.GetString(0), Convert.ToString(dataReader.GetDouble(2)), Convert.ToString(1.0 - dataReader.GetDouble(3)), Convert.ToString(dataReader.GetInt32(4)) };
                    itemsList.Items.Add(new ListViewItem(row));
                }
            }
        }
    }
}
