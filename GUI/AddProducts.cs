using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalmartDesktopAPP.DL;
using WalmartDesktopAPP.BL;
using WalmartDesktopAPP.Path;
namespace WalmartDesktopAPP.GUI
{
    public partial class AddProducts : UserControl
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        public void ByindProductList()
        {
            AddProductGrid.DataSource = null;
            AddProductGrid.DataSource = ProductDL.Products;
            AddProductGrid.Refresh();
        }
        private void AddProducts_Load(object sender, EventArgs e)
        {
            ProductDL.Loadproducts(ProductsPath.ProductPath);
            AddProductGrid.DataSource = ProductDL.Products;
        }

        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string CatagoryName = CatagoryText.Text;
                string ProductName = ProductText.Text;
                int Quantity = int.Parse(QuantityText.Text);
                int Price = int.Parse(PriceText.Text);
                int Discount = int.Parse(discountText.Text);
                ProductBL product = new ProductBL(CatagoryName, ProductName, Price, Quantity, Discount);
                ProductDL.AddProductToList(product);
                ProductDL.StoreProductsInFile(product);
                ByindProductList();
                CatagoryText.Clear();
                ProductText.Clear();
                QuantityText.Clear();
                PriceText.Clear();
                discountText.Clear();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
