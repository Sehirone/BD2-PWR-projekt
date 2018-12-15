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
        Product chosenProduct;

        public CheckProductForm(OracleConnection conn)
        {
            this.conn = conn;
            chosenProduct = new Product();
            InitializeComponent();
        }

        public CheckProductForm(OracleConnection conn, Product chosenProduct)
        {
            this.conn = conn;
            this.chosenProduct = chosenProduct;
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                itemsList.Items.Clear();

                string productName = productNameBox.Text == "" ? "*!@NOTHING TO LOOK FOR@!*" : productNameBox.Text;
                string barCode = barCodeBox.Text;

                OracleCommand getProductCmd = new OracleCommand();
                getProductCmd.Connection = conn;
                getProductCmd.CommandText = "select PRODUCT_ID,PRODUCT_NAME,BARCODE,PRICE,PRICE_CUT,QUANTITY from PRODUKTY WHERE BARCODE = \'" + barCode + "\' OR PRODUCT_NAME LIKE \'%" + productName + "%\'";
                OracleDataReader dataReader = getProductCmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string[] row = { Convert.ToString(dataReader.GetInt32(0)), dataReader.GetString(1), Convert.ToString(dataReader.GetDouble(3)), Convert.ToString(1.0 - dataReader.GetDouble(4)), Convert.ToString(dataReader.GetInt32(5)) , dataReader.GetString(2)};
                    itemsList.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void itemsList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            chosenProduct.ProductId = Convert.ToInt32(itemsList.SelectedItems[0].SubItems[0].Text);
            chosenProduct.ProductName = itemsList.SelectedItems[0].SubItems[1].Text;
            chosenProduct.Price = Convert.ToDouble(itemsList.SelectedItems[0].SubItems[2].Text);
            chosenProduct.PriceCut = 1.0 - Convert.ToDouble(itemsList.SelectedItems[0].SubItems[3].Text);
            chosenProduct.Quantity = Convert.ToInt32(itemsList.SelectedItems[0].SubItems[4].Text);
            chosenProduct.BarCode = itemsList.SelectedItems[0].SubItems[5].Text;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}