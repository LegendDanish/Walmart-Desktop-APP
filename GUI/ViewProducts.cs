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
    public partial class ViewProducts : UserControl
    {
        public ViewProducts()
        {
            InitializeComponent();
        }
        public void DataByind()
        {
            ViewProductGridV.DataSource = null;
            ViewProductGridV.DataSource = ProductDL.Products;
            ViewProductGridV.Refresh();
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
                     product =  ProductDL.Products.OrderByDescending(o => o.Prices).ToList();
                }
            }
            else if (TypeCombobox.Text == "Discount")
            {
                if (SortOrderBox.Text == "Ascending")
                {
                    product  =  ProductDL.Products.OrderBy(o => o.Discounts).ToList();
                }
                else if (SortOrderBox.Text == "Descending")
                {
                    product  =  ProductDL.Products.OrderByDescending(o => o.Discounts).ToList();
                }
            }
            ViewProductGridV.DataSource = null;
            ViewProductGridV.DataSource = product;
            ViewProductGridV.Refresh();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        public void LoadForm()
        {
           
            ProductDL.Loadproducts(ProductsPath.ProductPath);
            DataByind();

        }
        private void ViewProducts_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string Catagory = ViewSeachBoxtext.Text;
            if (ProductDL.ValidCatagory(Catagory))
            {
                List<ProductBL> product = ProductDL.GetSearchProductList(Catagory);
                ViewProductGridV.DataSource = null;
                ViewProductGridV.DataSource = product;
                ViewProductGridV.Refresh();
            }
            else
            {
                MessageBox.Show("You Enter Wrong Catagory Check Again!");
            }
            ViewSeachBoxtext.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SortProduct();
        }

        private void LoadViewButton_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
