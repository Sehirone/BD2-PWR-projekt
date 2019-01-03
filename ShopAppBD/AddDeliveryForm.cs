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
    public partial class AddDeliveryForm : Form
    {
        OracleConnection conn;
        User user;
        Product searchedProduct;


        public AddDeliveryForm(OracleConnection conn, User user)
        {
            this.conn = conn;
            this.user = user;
            searchedProduct = new Product();
            InitializeComponent();
            infoBox.Text = "";
            SetupSuppliers();
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            CheckProductForm checkProductForm = new CheckProductForm(conn, searchedProduct);
            checkProductForm.ShowDialog();
            if (checkProductForm.DialogResult == DialogResult.Yes)
            {
                string[] row = {Convert.ToString(searchedProduct.ProductId),
                                searchedProduct.ProductName,
                                Convert.ToString(searchedProduct.Price),
                                Convert.ToString(1.0 - searchedProduct.PriceCut),
                                Convert.ToString(searchedProduct.Quantity),
                                searchedProduct.BarCode,
                                "1"};
                if(!ItemAlreadyOnList(row[0]))
                {
                    itemsList.Items.Add(new ListViewItem(row));
                } else
                {
                    infoBox.Text = "Przedmiot znajduje się już na liście!";
                }
            }
        }

        private void SetupSuppliers()
        {
            OracleCommand getSuppCmd = new OracleCommand();
            getSuppCmd.Connection = conn;
            getSuppCmd.CommandText = "select SUPPLIER_ID,SUPPLIER_NAME from DOSTAWCY";
            OracleDataReader dataReader = getSuppCmd.ExecuteReader();

            while (dataReader.Read())
            {
                suppliersBox.Items.Add(Convert.ToString(dataReader.GetInt32(0)) + ":" + dataReader.GetString(1));
            }
        }

        private Boolean ItemAlreadyOnList(string id)
        {
            foreach (ListViewItem item in itemsList.Items)
            {
                if(item.SubItems[0].Text == id)
                {
                    return true;
                }
            }
            return false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in itemsList.SelectedItems)
            {
                itemsList.Items.Remove(item);
            }
        }

        private void setQuantityButton_Click(object sender, EventArgs e)
        {
            int parseResult;
            if(Int32.TryParse(quantityBox.Text, out parseResult))
            {
                foreach (ListViewItem item in itemsList.SelectedItems)
                {
                    item.SubItems[6].Text = quantityBox.Text;
                }
            } else
            {
                infoBox.Text = "Ilość musi być liczbą całkowitą!";
            }
        }

        private void addDeliveryButton_Click(object sender, EventArgs e)
        {
            if (itemsList.Items.Count > 0)
            {
                if (suppliersBox.SelectedIndex > -1)
                {
                    OracleTransaction myTrans = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                    try
                    {
                        OracleCommand addDelivery = new OracleCommand();
                        addDelivery.Connection = conn;
                        addDelivery.Transaction = myTrans;
                        addDelivery.CommandText = "INSERT INTO DOSTAWY (SUPPLIER_ID, EMPLOYEE_ID) VALUES (:p1,:p2)";
                        addDelivery.Parameters.Add("p1", OracleDbType.Int32).Value = Int32.Parse(suppliersBox.Text.Split(':')[0]);
                        addDelivery.Parameters.Add("p2", OracleDbType.Int32).Value = Int32.Parse(user.Login);
                        int updates = addDelivery.ExecuteNonQuery();

                        OracleCommand getInsertedId = new OracleCommand();
                        getInsertedId.Connection = conn;
                        getInsertedId.Transaction = myTrans;
                        getInsertedId.CommandText = "select max(shipment_id) from DOSTAWY";
                        OracleDataReader dataReader = getInsertedId.ExecuteReader();
                        dataReader.Read();
                        int shipment_id = dataReader.GetInt32(0);

                        foreach (ListViewItem item in itemsList.Items)
                        {
                            OracleCommand addDeliveredItem = new OracleCommand();
                            addDeliveredItem.Connection = conn;
                            addDeliveredItem.Transaction = myTrans;
                            addDeliveredItem.CommandText = "INSERT INTO ZAWARTOSC_DOSTAW (SHIPMENT_ID, PRODUCT_ID, PRODUCT_QUANTITY) VALUES (:p1,:p2,:p3)";
                            addDeliveredItem.Parameters.Add("p1", OracleDbType.Int32).Value = shipment_id;
                            addDeliveredItem.Parameters.Add("p2", OracleDbType.Int32).Value = Int32.Parse(item.SubItems[0].Text);
                            addDeliveredItem.Parameters.Add("p3", OracleDbType.Int32).Value = Int32.Parse(item.SubItems[6].Text);
                            updates = addDeliveredItem.ExecuteNonQuery();
                        }

                        myTrans.Commit();

                        // Cleanup
                        itemsList.Items.Clear();
                        infoBox.Text = "Dodano dostawę!";
                    }
                    catch(Exception)
                    {
                        myTrans.Rollback();
                        infoBox.Text = "Nie udało się dodać dostawy - spróbuj ponownie!";
                    }
                    
                } else
                {
                    infoBox.Text = "Dostawca musi zostać wybrany!";
                }
            } else
            {
                infoBox.Text = "Nie można dodać pustej dostawy!";
            }
        }
    }
}