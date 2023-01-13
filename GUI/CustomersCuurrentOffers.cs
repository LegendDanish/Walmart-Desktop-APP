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
    public partial class CustomersCuurrentOffers : UserControl
    {
        public CustomersCuurrentOffers()
        {
            InitializeComponent();
        }
        public void CheckOfferProductValid(string productName,int Price,int Discount)
        {
            ProductBL product = ProductDL.CheckPRoductValid(productName);
            if (product != null)
            {
                product.Quantites = product.Quantites - 1;
                product.Products = productName;
                int Quantites = 1;
                ProductBL ordersProduct = new ProductBL(product.Catagories, product.Products, Price, Quantites, Discount);
                CustomerDL.AddOrderToList(ordersProduct);
                CustomerDL.storeOrders(ordersProduct, CustomerForm.CustomerName);
                MessageBox.Show("Your Orders SuccessFully Add To Your Orders List Please Visit Generate Bill Option!");

            }
            else
            {
                MessageBox.Show("Sorry Now Product is Not Available!");
            }
         
        }

        private void CustomersCuurrentOffers_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Offer1Discounttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Offer1Discounttxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Offer1BuyButton_Click(object sender, EventArgs e)
        { 
            string ProductName = Offer1ProductName.Text;
            int Price = int.Parse(Offer1Price.Text);
            int Discount = int.Parse(Offer2Discount.Text);
            CheckOfferProductValid(ProductName,Price,Discount);

        }

        private void Offer2BuyButton_Click(object sender, EventArgs e)
        {
            string ProductName = Offer2ProductName.Text;
            int Price = int.Parse(Offer2Price.Text);
            int Discount = int.Parse(Offer2Discount.Text);
            CheckOfferProductValid(ProductName, Price, Discount);
        }

        private void Offer3BuyButton_Click(object sender, EventArgs e)
        {
            string ProductName = Offer3ProductName.Text;
            int Price = int.Parse(Offer3Price.Text);
            int Discount = int.Parse(Offer3Discount.Text);
            CheckOfferProductValid(ProductName, Price, Discount);

        }

        private void Offer4BuyButton_Click(object sender, EventArgs e)
        {
            string ProductName = Offer4ProductName.Text;
            int Price = int.Parse(Offer4Price.Text);
            int Discount = int.Parse(Offer4Discount.Text);
            CheckOfferProductValid(ProductName, Price, Discount);
        }

        private void Offer8BuyButton_Click(object sender, EventArgs e)
        {
            string ProductName = Offer8ProductName.Text;
            int Price = int.Parse(Offer8Price.Text);
            int Discount = int.Parse(Offer8Discount.Text);
            CheckOfferProductValid(ProductName, Price, Discount);
        }

        private void Offer6Button_Click(object sender, EventArgs e)
        {
            string ProductName = Offer6ProductName.Text;
            int Price = int.Parse(Offer6Price.Text);
            int Discount = int.Parse(Offer6Discount.Text);
            CheckOfferProductValid(ProductName, Price, Discount);
        }

        private void Offer5BuyButton_Click(object sender, EventArgs e)
        {
            string ProductName = Offer5ProductName.Text;
            int Price = int.Parse(Offer5Price.Text);
            int Discount = int.Parse(Offer5Discount.Text);
            CheckOfferProductValid(ProductName, Price, Discount);
        }

        private void Offer7BuyButton_Click(object sender, EventArgs e)
        {
            string ProductName = Offer7ProductName.Text;
            int Price = int.Parse(Offer7Price.Text);
            int Discount = int.Parse(Offer7Discount.Text);
            CheckOfferProductValid(ProductName, Price, Discount);
        }
    }
}
