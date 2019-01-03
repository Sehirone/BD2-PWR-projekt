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
    public partial class DeliveredGoodsForm : Form
    {
        int supplier_id;
        OracleConnection conn;

        public DeliveredGoodsForm(OracleConnection conn, int supplier_id)
        {
            this.supplier_id = supplier_id;
            this.conn = conn;
            InitializeComponent();
            getDeliveries();
        }

        private void getDeliveries()
        {
            OracleCommand getDeliveryCmd = new OracleCommand();
            getDeliveryCmd.Connection = conn;
            getDeliveryCmd.CommandText = "select DOSTAWY.SHIPMENT_ID, DOSTAWY.SHIPMENT_DATE, PRACOWNICY.FIRST_NAME, PRACOWNICY.LAST_NAME from DOSTAWY INNER JOIN PRACOWNICY ON DOSTAWY.employee_ID = PRACOWNICY.employee_ID WHERE DOSTAWY.supplier_id = " + Convert.ToString(supplier_id);
            OracleDataReader dataReader = getDeliveryCmd.ExecuteReader();

            // sets all deliveries
            while(dataReader.Read())
            {
                string[] row = {Convert.ToString(dataReader.GetInt32(0)),
                                 (Convert.ToString(dataReader.GetOracleDate(1)).Split(' '))[0],
                                 dataReader.GetString(2) + " " + dataReader.GetString(3) ,
                                 ""};
                deliveriesView.Items.Add(new ListViewItem(row));
            }

            // sets contents for each delivery
            foreach(ListViewItem item in deliveriesView.Items)
            {
                OracleCommand getContentsCmd = new OracleCommand();
                getContentsCmd.Connection = conn;
                getContentsCmd.CommandText = "SELECT PRODUKTY.PRODUCT_NAME, ZAWARTOSC_DOSTAW.PRODUCT_QUANTITY FROM ZAWARTOSC_DOSTAW INNER JOIN PRODUKTY ON PRODUKTY.PRODUCT_ID = ZAWARTOSC_DOSTAW.PRODUCT_ID WHERE ZAWARTOSC_DOSTAW.shipment_id = " + item.SubItems[0].Text;
                OracleDataReader dataReader2 = getContentsCmd.ExecuteReader();

                String contents = "";

                while(dataReader2.Read())
                {
                    contents += Convert.ToString(dataReader2.GetInt32(1)) + "x " + dataReader2.GetString(0) + ", ";
                }

                // Remove last ','
                if (contents.LastIndexOf(',') != -1)
                {
                    contents = contents.Remove(contents.LastIndexOf(','), 1);
                }

                item.SubItems[3].Text = contents;
            }

            deliveriesView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
