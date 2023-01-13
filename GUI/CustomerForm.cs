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
using System.Diagnostics;

namespace WalmartDesktopAPP.GUI
{
    public partial class CustomerForm : Form
    {
        public static string CustomerName;
        public CustomerForm(string Name)
        {
            InitializeComponent();
            SlidePanel2.Height = cutomerHomeButton.Height;
            SlidePanel2.Top = cutomerHomeButton.Top;
            customerHomeForm1.BringToFront();
            CustomerName = Name;
        }

        private void CurrentOfferButton_Click(object sender, EventArgs e)
        {
            SlidePanel2.Height = CurrentOfferButton.Height;
            SlidePanel2.Top = CurrentOfferButton.Top;
            customersCuurrentOffers1.BringToFront();
        }

        private void cutomerHomeButton_Click(object sender, EventArgs e)
        {
            SlidePanel2.Height = cutomerHomeButton.Height;
            SlidePanel2.Top = cutomerHomeButton.Top;
            customerHomeForm1.BringToFront();
        }

        private void customersViewProductButton_Click(object sender, EventArgs e)
        {
            SlidePanel2.Height = customersViewProductButton.Height;
            SlidePanel2.Top = customersViewProductButton.Top;
            viewProducts1.BringToFront();
        }

        private void GenerateBillButton_Click(object sender, EventArgs e)
        {
            SlidePanel2.Height = GenerateBillButton.Height;
            SlidePanel2.Top = GenerateBillButton.Top;
            generateBill1.BringToFront();
        }

        private void buyProduct1_Load(object sender, EventArgs e)
        {

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            SlidePanel2.Height = BuyButton.Height;
            SlidePanel2.Top = BuyButton.Top;
            buyProduct1.BringToFront();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            CustomerNameText.Text = CustomerName;
            if (CustomerDL.Customers1.Count == 0)
            {
                CustomerDL.LoadCustomers(CustomerPath.CustomersPath);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure? You Want To Logout!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SignInForm form = new SignInForm();
                form.Show();
                this.Hide();
                Muser Customer = MuserDL.GetCustomerDetail(CustomerForm.CustomerName);
             
                CustomerBL cust =  CustomerDL.AssignListToCustomer(CustomerDL.CustomerOrders1,Customer);
                if (cust != null)
                {
                    CustomerDL.AddCustomersToList(cust);
                }
                if(CustomerDL.Customers1.Count != 0)
                {
                    MessageBox.Show(CustomerDL.Customers1.Count.ToString());
                }
                CustomerDL.StoreCustomers();


            }
            else if (dialogResult == DialogResult.No)
            {

                this.Activate();
            }
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure? You Want To Logout!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SignInForm form = new SignInForm();
                form.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

                this.Activate();
            }
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conatct With us At Email: dnmughal54321@gmail.com", "Contact us", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/");
        }

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeAdminAccount1.BringToFront();
        }
    }
}
