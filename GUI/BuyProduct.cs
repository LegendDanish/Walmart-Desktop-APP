using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalmartDesktopAPP.BL;
using WalmartDesktopAPP.DL;
using WalmartDesktopAPP.Path;
namespace WalmartDesktopAPP.GUI
{
    public partial class BuyProduct : UserControl
    {
        public BuyProduct()
        {
            InitializeComponent();
        }

       
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DataByind()
        {
            BuyGridView.DataSource = null;
            BuyGridView.DataSource = ProductDL.Products;
            BuyGridView.Refresh();
        }
        public void LoadForm()
        {

            ProductDL.Loadproducts(ProductsPath.ProductPath);
            DataByind();

        }
        private void BuyProduct_Load(object sender, EventArgs e)
        {
            ProductDL.Loadproducts(ProductsPath.ProductPath);
            BuyGridView.DataSource = ProductDL.Products;
                
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Quantity = int.Parse(customerQuantitytxt.Text);
                ProductBL orders = (ProductBL)BuyGridView.CurrentRow.DataBoundItem;
                if (orders.Quantites > Quantity)
                {
                    orders.Quantites = orders.Quantites - Quantity;
                    ProductBL ordersBill = new ProductBL(orders.Catagories, orders.Products, orders.Prices, orders.Quantites, orders.Discounts);
                    ordersBill.Quantites = Quantity;
                    int Price  = ProductDL.CalculatePrice(ordersBill);
                    ordersBill.Prices = Price;
                    CustomerDL.AddOrderToList(ordersBill);
                    CustomerDL.storeOrders(ordersBill,CustomerForm.CustomerName);
                    MessageBox.Show("Your Orders SuccessFully Add To Your Orders List Please Visit Generate Bill Option!");
                }
                customerQuantitytxt.Clear();
            }
            catch 
            {
                MessagePanel.Visible = true;
            }
            customerQuantitytxt.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string Catagory = searchtxt.Text;
            if (ProductDL.ValidCatagory(Catagory))
            {
                List<ProductBL> product = ProductDL.GetSearchProductList(Catagory);
                BuyGridView.DataSource = null;
                BuyGridView.DataSource = product;
                BuyGridView.Refresh();
            }
            else
            {
                MessageBox.Show("You Enter Wrong Catagory Check Again!");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
        public void SortProduct()
        {
            List<ProductBL> product = new List<ProductBL>();
            if (TypeCombobox.Text == "Price")
            {
                if (SortOrderBox.Text == "Ascending")
                {
                    product = ProductDL.Products.OrderBy(o => o.Prices).ToList();
                }
                else if (SortOrderBox.Text == "Descending")
                {
                    product = ProductDL.Products.OrderByDescending(o => o.Prices).ToList();
                }
            }
            else if (TypeCombobox.Text == "Discount")
            {
                if (SortOrderBox.Text == "Ascending")
                {
                    product = ProductDL.Products.OrderBy(o => o.Discounts).ToList();
                }
                else if (SortOrderBox.Text == "Descending")
                {
                    product = ProductDL.Products.OrderByDescending(o => o.Discounts).ToList();
                }
            }
            BuyGridView.DataSource = null;
            BuyGridView.DataSource = product;
            BuyGridView.Refresh();
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            SortProduct();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
