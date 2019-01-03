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
    public partial class SuppliersForm : Form
    {
        OracleConnection conn;

        public SuppliersForm(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            setupList();
        }

        private void setupList()
        {
            suppliersView.Items.Clear();

            OracleCommand getSuppCmd = new OracleCommand();
            getSuppCmd.Connection = conn;
            getSuppCmd.CommandText = "select SUPPLIER_ID,SUPPLIER_NAME,NUMBER_OF_SHIPMENTS from DOSTAWCY";
            OracleDataReader dataReader = getSuppCmd.ExecuteReader();

            while (dataReader.Read())
            {
                string[] row = { Convert.ToString(dataReader.GetInt32(0)), dataReader.GetString(1), Convert.ToString(dataReader.GetInt32(2)) };
                suppliersView.Items.Add(new ListViewItem(row));
            }
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            if(nameBox.Text != "")
            {
                OracleCommand addSupplier = new OracleCommand();
                addSupplier.Connection = conn;
                addSupplier.CommandText = "INSERT INTO DOSTAWCY (SUPPLIER_NAME) VALUES (:p1)";
                addSupplier.Parameters.Add("p1", OracleDbType.Varchar2).Value = nameBox.Text;
                int updates = addSupplier.ExecuteNonQuery();
                setupList();
            }
        }

        private void suppliersView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (suppliersView.SelectedItems.Count > 0)
            {
                DeliveredGoodsForm deliveredGoodsForm = new DeliveredGoodsForm(conn, Int32.Parse(suppliersView.SelectedItems[0].SubItems[0].Text));
                deliveredGoodsForm.ShowDialog();
            }
        }
    }
}
