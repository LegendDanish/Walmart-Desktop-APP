using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalmartDesktopAPP.GUI
{
    public partial class AdminMainPage : UserControl
    {
        public AdminMainPage()
        {
            InitializeComponent();
            
        }

        private void AdminMainPageSearchBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(AdminMainPageSearchBox.Text == "Customer" || AdminMainPageSearchBox.Text == "customer")
            {
                MessageBox.Show("Please Visit Manage Customer Option", "Search", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Your Seach is Not Availabe!", "ERROR", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
    }
}
