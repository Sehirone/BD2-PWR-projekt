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
    public partial class PurchaseDetailsForm : Form
    {
        OracleConnection conn;

        public PurchaseDetailsForm(OracleConnection conn, string saleId)
        {
            this.conn = conn;
            InitializeComponent();

            OracleCommand getProducts = new OracleCommand();
            getProducts.Connection = conn;
            getProducts.CommandText = "select SPRZEDANE_RZECZY.PRODUCT_ID, SPRZEDANE_RZECZY.ITEM_QUANTITY, PRODUKTY.PRODUCT_NAME, PRODUKTY.PRICE, PRODUKTY.PRICE_CUT from SPRZEDANE_RZECZY INNER JOIN PRODUKTY ON SPRZEDANE_RZECZY.product_id = PRODUKTY.product_id WHERE SPRZEDANE_RZECZY.sale_id = " + saleId;
            OracleDataReader dataReader = getProducts.ExecuteReader();
            while (dataReader.Read())
            {
                string[] row = { Convert.ToString(dataReader.GetInt32(0)),
                                 dataReader.GetString(2),
                                 Convert.ToString(dataReader.GetDouble(3) * dataReader.GetDouble(4)),
                                 Convert.ToString(dataReader.GetInt32(1)),
                                 Convert.ToString(dataReader.GetDouble(3) * dataReader.GetDouble(4) * dataReader.GetInt32(1))
                                 };
                purchasesList.Items.Add(new ListViewItem(row));
            }
        }
    }
}
