using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WalmartDesktopAPP.BL;
using WalmartDesktopAPP.DL;
using WalmartDesktopAPP.Path;

namespace WalmartDesktopAPP.GUI
{
    public partial class AdminForm : Form
    {
        public static string AdminName;
       
        public AdminForm(string Name)
        {
            InitializeComponent();
            ProductDL.Loadproducts(ProductsPath.ProductPath);
            SlidePanel.Height = HomeButton.Height;
            SlidePanel.Top = HomeButton.Top;
            adminMainPage1.BringToFront();
            AdminName = Name;
        }
       
       
        private void AdminForm_Load(object sender, EventArgs e)
        {
            AdminNametext.Text = AdminName;
            ProductDL.Loadproducts(ProductsPath.ProductPath);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SlidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateProducts1_Load(object sender, EventArgs e)
        {
            
        }

        private void viewCustomers1_Load(object sender, EventArgs e)
        {

        }

        private void deleteProducts1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = HomeButton.Height;
            SlidePanel.Top = HomeButton.Top;
            adminMainPage1.BringToFront();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = DeleteButton.Height;
            SlidePanel.Top = DeleteButton.Top;
            deleteProducts1.BringToFront();
        }

        private void SlidePanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = AddProductButton.Height;
            SlidePanel.Top = AddProductButton.Top;
            addProducts1.BringToFront();
        }

        private void ViewProductButton_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = ViewProductButton.Height;
            SlidePanel.Top = ViewProductButton.Top;
            viewProducts1.BringToFront();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
           
            SlidePanel.Height = UpdateButton.Height;
            SlidePanel.Top = UpdateButton.Top;
            updateProducts1.BringToFront();          
        }

        private void CustomerViewButton_Click(object sender, EventArgs e)
        {

            SlidePanel.Height = CustomerViewButton.Height;
            SlidePanel.Top = CustomerViewButton.Top;
            viewCustomers1.BringToFront();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.mozilla.org/en-US/firefox/");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure? You Want To Logout!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                SignInForm form = new SignInForm();
                form.Show();
                this.Hide();
            }
            else if(dialogResult == DialogResult.No)
            {
                
                this.Activate();
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeAdminAccount1.BringToFront();          
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
