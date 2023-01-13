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
using WalmartDesktopAPP.GUI;
using WalmartDesktopAPP.Path;
namespace WalmartDesktopAPP.GUI
{
    public partial class ViewCustomers : UserControl
    {
        public ViewCustomers()
        {
            InitializeComponent();
        }
        public static string CustomerName;
        public static int count;
        public void DataByind()
        {
            ViewcustomerGrid.DataSource = null;
            ViewcustomerGrid.DataSource = CustomerDL.Customers1;
            ViewcustomerGrid.Refresh();
        }
        public void LoadForm()
        {
            CustomerDL.LoadCustomers(CustomerPath.CustomersPath);
        }
        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            FullFillOrderButton.Visible = false;
            CustomerDL.LoadCustomers(CustomerPath.CustomersPath);
            ViewcustomerGrid.DataSource = CustomerDL.Customers1;
        }

        private void ViewCustomers_Load_1(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            count = 0;
            if (CustomerDL.Customers1.Count == 0)
            {
                CustomerDL.LoadCustomers(CustomerPath.CustomersPath);
            }
            DataByind();
            
            FullFillOrderButton.Visible = false;
        }
        public void OrdersByind(CustomerBL customer)
        {
            try
            {
                ViewcustomerGrid.DataSource = null;
                ViewcustomerGrid.DataSource = customer.BuyProduct;
                ViewcustomerGrid.Refresh();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void CustomerEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDL.LoadOrders(ProductsPath.OrdersPath, CustomerName);
                CustomerBL customer = CustomerDL.GetCustomerObject(CustomerName);
                OrdersByind(customer);
              
                FullFillOrderButton.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Select Any Row");
            }
            count = 1;
           
        }

        private void ViewcustomerGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
            int indexRow = e.RowIndex;
            DataGridViewRow row = ViewcustomerGrid.Rows[indexRow];
            if (count == 0)
            {
                Nametxt.Text = row.Cells[1].Value.ToString();
                Passwordtxt.Text = row.Cells[2].Value.ToString();
                Phonetxt.Text = row.Cells[4].Value.ToString();
                CustomerName = Nametxt.Text;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerDL.LoadallCutomerOrders(ProductsPath.OrdersPath);
            try
            {
                ProductBL product = (ProductBL)ViewcustomerGrid.CurrentRow.DataBoundItem;
                SpecificCustomerBL customer = new SpecificCustomerBL(CustomerName, product.Catagories, product.Products, product.Prices, product.Quantites, product.Discounts);
                CustomerDL.FullFillOrders(customer);
                CustomerDL.StoreAllCustomersOrders();
                MessageBox.Show(CustomerName);
                CustomerBL Customer = CustomerDL.GetCustomerObject(CustomerName);
                CustomerDL.DeleteCustomer(Customer.BuyProduct, product,Customer);
                CustomerDL.StoreCustomers();
             
                MessageBox.Show(Customer.BuyProduct.Count.ToString());
                OrdersByind(Customer);
             
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
