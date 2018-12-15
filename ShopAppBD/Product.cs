using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppBD
{
    public class Product
    {
        private int productId = 0;
        private string productName;
        private string barCode;
        private double price;
        private double priceCut;
        private int quantity;

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string BarCode { get => barCode; set => barCode = value; }
        public double Price { get => price; set => price = value; }
        public double PriceCut { get => priceCut; set => priceCut = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
