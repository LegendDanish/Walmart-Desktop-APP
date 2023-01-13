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
    public partial class UpdateProducts : UserControl
    {
        public UpdateProducts()
        {
            InitializeComponent();
            
        }
        public void DataByind()
        {
            UpdateGridView.DataSource = null;
            UpdateGridView.DataSource = ProductDL.Products;
            UpdateGridView.Refresh();
        }
       /* I Make This Attributes Because I Make Only Form For Update Products.
        So Thats Why I Can  Make Object of ProductBL that Passes To
        Another Form.*/
        public string catagoryName;
        public string productName;
        public void LoadForm()
        {

            ProductDL.Loadproducts(ProductsPath.ProductPath);
            DataByind();

        }
        private void LoadViewButton_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string CatagoryName = UpdateCatagorytext.Text;
            string ProductName = UpdateProductText.Text;
            int Quantity = int.Parse(UpdateQuantityText.Text);
            int Price = int.Parse(UpdatePriceText.Text);
            int discount = int.Parse(UpdateDiscountText.Text);
            ProductBL product = new ProductBL(CatagoryName, ProductName, Price, Quantity, discount);
            ProductDL.UpdateProduct(catagoryName, productName, product);
            ProductDL.StoreAllDataInfile(ProductsPath.ProductPath,ProductDL.Products);
            DataByind();
            UpdateCatagorytext.Clear();
            UpdateProductText.Clear();
            UpdateQuantityText.Clear();
            UpdatePriceText.Clear();
            UpdateDiscountText.Clear();
        }

        private void UpdateGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = UpdateGridView.Rows[indexRow];
            UpdateCatagorytext.Text = row.Cells[0].Value.ToString();
            UpdateProductText.Text = row.Cells[1].Value.ToString();
            UpdatePriceText.Text = row.Cells[2].Value.ToString();
            UpdateQuantityText.Text = row.Cells[3].Value.ToString();
            UpdateDiscountText.Text = row.Cells[4].Value.ToString();
            catagoryName = UpdateCatagorytext.Text;
            productName = UpdateProductText.Text;
        }
    }
}
