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
    public partial class GenerateBill : UserControl
    {
        public GenerateBill()
        {
            InitializeComponent();
        }

        private static int sum;
        public static int Bills;
        public void OrdersByind()
        {
            GenerateBillGrid.DataSource = null;
            GenerateBillGrid.DataSource = CustomerDL.CustomerOrders1;
            GenerateBillGrid.Refresh();
        }
        private void GenerateBill_Load(object sender, EventArgs e)
        {
            CustomerDL.LoadOrders(ProductsPath.OrdersPath,CustomerForm.CustomerName);
            GenerateBillGrid.DataSource = CustomerDL.CustomerOrders1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadForm()
        {
            CustomerDL.LoadOrders(ProductsPath.OrdersPath, CustomerForm.CustomerName);
            OrdersByind();
        }
        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProductBL product = (ProductBL)GenerateBillGrid.CurrentRow.DataBoundItem;
                CustomerDL.DeleteOrders(product);
                ProductDL.StoreAllDataInfile(ProductsPath.OrdersPath, CustomerDL.CustomerOrders1);
                OrdersByind();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void GenerateBillButton_Click(object sender, EventArgs e)
        {
            sum = 0;
            
            foreach(ProductBL Product in CustomerDL.CustomerOrders1)
            {
                sum = sum + Product.Prices;
            }
            Bills = sum;
            GenerateBillTXT.Text = "PKR " + sum;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
