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
        User user;
        Product searchedProduct;
        Double totalCost;

        public SellingForm(OracleConnection conn, User user)
        {
            this.conn = conn;
            this.user = user;
            searchedProduct = new Product();
            totalCost = 0;
            InitializeComponent();
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            CheckProductForm checkProductForm = new CheckProductForm(conn, searchedProduct);
            checkProductForm.ShowDialog();
            if(checkProductForm.DialogResult == DialogResult.Yes)
            {
                string[] row = {Convert.ToString(searchedProduct.ProductId),
                                searchedProduct.ProductName,
                                Convert.ToString(searchedProduct.Price),
                                Convert.ToString(1.0 - searchedProduct.PriceCut),
                                Convert.ToString(searchedProduct.Quantity),
                                searchedProduct.BarCode};
                itemsList.Items.Add(new ListViewItem(row));
                totalCost += searchedProduct.Price * searchedProduct.PriceCut;
                totalCost = Math.Round(totalCost, 2);
                totalCostBox.Text = "Cena łącznie: " + Convert.ToString(totalCost);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in itemsList.SelectedItems)
            {
                totalCost -= Convert.ToDouble(item.SubItems[2].Text) * (1.0 - Convert.ToDouble(item.SubItems[3].Text));
                totalCost = Math.Round(totalCost, 2);
                itemsList.Items.Remove(item);
            }
            totalCostBox.Text = "Cena łącznie: " + Convert.ToString(totalCost);
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            OracleCommand addSale = new OracleCommand();
            addSale.Connection = conn;
            addSale.CommandText = "INSERT INTO SPRZEDAZE (EMPLOYEE_ID, SALE_PRICE) VALUES (:p1,:p2)";
            addSale.Parameters.Add("p1", OracleDbType.Int32).Value = Int32.Parse(user.Login);
            addSale.Parameters.Add("p2", OracleDbType.Double).Value = totalCost;
            int updates = addSale.ExecuteNonQuery();

            OracleCommand getInsertedId = new OracleCommand();
            getInsertedId.Connection = conn;
            getInsertedId.CommandText = "select max(sale_id) from SPRZEDAZE";
            OracleDataReader dataReader = getInsertedId.ExecuteReader();
            dataReader.Read();
            int sale_id = dataReader.GetInt32(0);

            while (itemsList.Items.Count > 0)
            {
                ListViewItem currentItem = (ListViewItem)itemsList.Items[0].Clone();
                int itemsCount = 0;
                foreach(ListViewItem item in itemsList.Items)
                {
                    if(currentItem.SubItems[0].Text == item.SubItems[0].Text)
                    {
                        itemsCount++;
                        itemsList.Items[item.Index].Remove();
                    }
                }
                OracleCommand addSoldItem = new OracleCommand();
                addSoldItem.Connection = conn;
                addSoldItem.CommandText = "INSERT INTO SPRZEDANE_RZECZY (SALE_ID, PRODUCT_ID, ITEM_QUANTITY) VALUES (:p1,:p2,:p3)";
                addSoldItem.Parameters.Add("p1", OracleDbType.Int32).Value = sale_id;
                addSoldItem.Parameters.Add("p2", OracleDbType.Double).Value = Double.Parse(currentItem.SubItems[0].Text);
                addSoldItem.Parameters.Add("p3", OracleDbType.Int32).Value = itemsCount;
                updates = addSoldItem.ExecuteNonQuery();
            }


            // Cleanup
            itemsList.Items.Clear();
            totalCost = 0;
            totalCostBox.Text = "Cena łącznie: " + Convert.ToString(totalCost);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in itemsList.SelectedItems)
            {
                itemsList.Items.Add((ListViewItem)item.Clone());
                totalCost += Convert.ToDouble(item.SubItems[2].Text) * (1.0 - Convert.ToDouble(item.SubItems[3].Text));
                totalCost = Math.Round(totalCost, 2);
            }
            totalCostBox.Text = "Cena łącznie: " + Convert.ToString(totalCost);
        }
    }
}
