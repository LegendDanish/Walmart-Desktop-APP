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
    public partial class DeleteProducts : UserControl
    {
        public DeleteProducts()
        {
            InitializeComponent();
        }
        public void DataByind()
        {
            DeleteGrid.DataSource = null;
            DeleteGrid.DataSource = ProductDL.Products;
            DeleteGrid.Refresh();
        }

        public void LoadForm()
        {

            ProductDL.Loadproducts(ProductsPath.ProductPath);
            DataByind();

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string Catagory = SearchDelBox.Text;
            if (ProductDL.ValidCatagory(Catagory))
            {
                List<ProductBL> product = ProductDL.GetSearchProductList(Catagory);
                DeleteGrid.DataSource = null;
                DeleteGrid.DataSource = product;
                DeleteGrid.Refresh();
            }
            else
            {
                MessageBox.Show("You Enter Wrong Catagory Check Again!");
            }
        }

        private void DeleteProducts_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadUpdateButton_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            ProductBL product = (ProductBL)DeleteGrid.CurrentRow.DataBoundItem;

            ProductDL.DeleteProduct(product);
            ProductDL.StoreAllDataInfile(ProductsPath.ProductPath, ProductDL.Products);
            DataByind();
            UpdateProducts Update = new UpdateProducts();
            Update.DataByind();
            ViewProducts View = new ViewProducts();
            View.DataByind();
            AddProducts AddProd = new AddProducts();
            AddProd.ByindProductList();
        }
    }
}
