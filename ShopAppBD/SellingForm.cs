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
        Double totalCost;

        public SellingForm(OracleConnection conn)
        {
            this.conn = conn;
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
            // TO DO update database
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
