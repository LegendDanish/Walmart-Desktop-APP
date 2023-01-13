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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            MuserDL.ReadData(UserId.UserIDPath);
            MessageBox.Show("Successfuly Data Read");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Passwordtex1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void UserNameTex1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure? You Want To Exit!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

                this.Activate();
            }
           
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if (UserNameTex1.Text != "User Name" && UserPasswordTex1.Text != "Password")
            {
                string UserName = UserNameTex1.Text;
                string Password = UserPasswordTex1.Text;

                Muser user = new Muser(UserName, Password);
                user = MuserDL.Signin(user);
                MessageText.Clear();
                MessageText.Visible = true;
                if (user != null)
                {
                    if (user.IsAdmin())
                    {
                        AdminForm Admin = new AdminForm(user.UserName);
                        Admin.Show();
                        this.Hide();

                    }
                    else
                    {
                        CustomerForm Customer = new CustomerForm(user.UserName);
                        
                        
                        Customer.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageText.ForeColor = Color.Red;
                    MessageText.Text = "Invalid UserName And Password";


                }
                UserNameTex1.Clear();
                UserPasswordTex1.Clear();
                UserNameTex1.Focus();

            }
            else
            {
                MessageBox.Show("Please Enter Valid Input Format");
            }
        }

        private void lblSignUP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.Show();
            this.Hide();
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void visibleeyebutton_Click(object sender, EventArgs e)
        {
            if(UserPasswordTex1.PasswordChar == '*')
            {
                invisibleeyebtn.BringToFront();
                UserPasswordTex1.PasswordChar = '\0';
            }
        }

        private void invisibleeyebtn_Click(object sender, EventArgs e)
        {
            if (UserPasswordTex1.PasswordChar == '\0')
            {
                visibleeyebutton.BringToFront();
                UserPasswordTex1.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.Show();
            this.Hide();
        }
    }
}
