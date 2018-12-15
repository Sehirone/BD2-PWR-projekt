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
    public partial class AddModifyProductForm : Form
    {
        OracleConnection conn;
        Product product;

        public AddModifyProductForm(OracleConnection conn)
        {
            this.conn = conn;
            product = new Product();
            InitializeComponent();
            infoBox.Text = "";
        }

        private Boolean checkDataCorrectness()
        {
            Boolean isDataCorrect = true;
            double tempDoubleResult;
            int tempIntResult;
            nameLabel.ForeColor = Color.Black;
            priceLabel.ForeColor = Color.Black;
            pricecutLabel.ForeColor = Color.Black;
            quantityLabel.ForeColor = Color.Black;
            barcodeLabel.ForeColor = Color.Black;
            if (nameBox.Text == "")
            {
                nameLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if(!double.TryParse(priceBox.Text, out tempDoubleResult))
            {
                priceLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if(tempDoubleResult < 0)
            {
                priceLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if (!double.TryParse(pricecutBox.Text, out tempDoubleResult))
            {
                pricecutLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if (tempDoubleResult < 0 || tempDoubleResult > 1)
            {
                pricecutLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if (!int.TryParse(quantityBox.Text, out tempIntResult))
            {
                quantityLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if(barcodeBox.Text.Length != 13)
            {
                barcodeLabel.ForeColor = Color.Red;
                isDataCorrect = false;
            }
            if(!isDataCorrect)
            {
                infoBox.Text = "Niepoprawne dane!";
            } else
            {
                infoBox.Text = "";
            }
            return isDataCorrect;
        }

        private void clearBoxes()
        {
            nameBox.Text = "";
            barcodeBox.Text = "";
            priceBox.Text = "";
            pricecutBox.Text = "";
            quantityBox.Text = "";
        }

        private void reset()
        {
            clearBoxes();
            product = new Product();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CheckProductForm checkProductForm = new CheckProductForm(conn, product);
            checkProductForm.ShowDialog();
            if (checkProductForm.DialogResult == DialogResult.Yes)
            {
                nameBox.Text = product.ProductName;
                priceBox.Text = Convert.ToString(product.Price);
                pricecutBox.Text = Convert.ToString(1.0 - product.PriceCut);
                quantityBox.Text = Convert.ToString(product.Quantity);
                barcodeBox.Text = product.BarCode;
                checkDataCorrectness();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(!checkDataCorrectness())
            {
                return;
            } else
            {
                OracleCommand addProduct = new OracleCommand();
                addProduct.Connection = conn;
                addProduct.CommandText = "INSERT INTO PRODUKTY (PRODUCT_NAME,BARCODE,PRICE,PRICE_CUT,QUANTITY) VALUES (:p1,:p2,:p3,:p4,:p5)";
                addProduct.Parameters.Add("p1", OracleDbType.Varchar2).Value = nameBox.Text;
                addProduct.Parameters.Add("p2", OracleDbType.Varchar2).Value = barcodeBox.Text;
                addProduct.Parameters.Add("p3", OracleDbType.Double).Value = double.Parse(priceBox.Text);
                addProduct.Parameters.Add("p4", OracleDbType.Double).Value = 1.0 - double.Parse(pricecutBox.Text);
                addProduct.Parameters.Add("p5", OracleDbType.Int32).Value = int.Parse(quantityBox.Text);
                int updates = addProduct.ExecuteNonQuery();
                infoBox.Text = "Dodano nowy produkt!";
                reset();
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (!checkDataCorrectness())
            {
                return;
            } else
            {
                if(product.ProductId == 0)
                {
                    infoBox.Text = "Aby edytować produkt najpierw go wyszukaj!";
                    return;
                } else
                {
                    OracleCommand modifyProduct = new OracleCommand();
                    modifyProduct.Connection = conn;
                    modifyProduct.CommandText = "UPDATE PRODUKTY SET PRODUCT_NAME = :p1, BARCODE = :p2, PRICE = :p3, PRICE_CUT = :p4, QUANTITY = :p5 WHERE PRODUCT_ID = :p6";
                    modifyProduct.Parameters.Add("p1", OracleDbType.Varchar2).Value = nameBox.Text;
                    modifyProduct.Parameters.Add("p2", OracleDbType.Varchar2).Value = barcodeBox.Text;
                    modifyProduct.Parameters.Add("p3", OracleDbType.Double).Value = double.Parse(priceBox.Text);
                    modifyProduct.Parameters.Add("p4", OracleDbType.Double).Value = 1.0 - double.Parse(pricecutBox.Text);
                    modifyProduct.Parameters.Add("p5", OracleDbType.Int32).Value = int.Parse(quantityBox.Text);
                    modifyProduct.Parameters.Add("p6", OracleDbType.Int32).Value = product.ProductId;
                    int updates = modifyProduct.ExecuteNonQuery();
                    infoBox.Text = "Zmodyfikowano produkt!";
                    reset();
                }
            }
        }
    }
}
