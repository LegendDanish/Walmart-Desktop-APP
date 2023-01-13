using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalmartDesktopAPP.BL
{
    public class ProductBL
    {
        private string catagories;
        private string products;
        private int prices;
        private int quantites;
        private int discounts;

        public ProductBL(string catagoryName, string productName, int productPrice, int productQuantity, int productDiscount)
        {
            Catagories = catagoryName;
            Products = productName;
            Prices = productPrice;
            Quantites = productQuantity;
            Discounts = productDiscount;

        }

        public ProductBL(string productName,int productQuantity,int productPrice)
        {
            Products = productName;
            Quantites = productQuantity;
            Prices = productPrice;
        }

        public string Catagories { get => catagories; set => catagories = value; }
        public string Products { get => products; set => products = value; }
        public int Prices
        {
            get => prices;
            set
            {
                if (value > 0)
                {
                    prices = value;
                }
            }
        }
        public int Quantites { get => quantites; set
        {
                if (value > 0)
                {
                    quantites = value;
                }
            }
        }
        public int Discounts { get => discounts; set => discounts = value; }
    }
}
