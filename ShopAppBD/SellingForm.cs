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
    public partial class SellingForm : Form
    {
        OracleConnection conn;
        Product searchedProduct;

        public SellingForm(OracleConnection conn)
        {
            this.conn = conn;
            searchedProduct = new Product();
            InitializeComponent();
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            CheckProductForm checkProductForm = new CheckProductForm(conn, searchedProduct);
            checkProductForm.ShowDialog();
        }
    }
}
