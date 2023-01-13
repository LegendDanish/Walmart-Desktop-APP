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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            bool flag = false;
            string UserName = UserNameTex2.Text;
            string Password = UserPasswordtex2.Text;
            string Role = RolecomboBox2.Text;
            string PhoneNo = UserPhoneno.Text;
            Muser user = new Muser(UserName, Password, Role,PhoneNo);

            foreach (Muser s in MuserDL.User)
            {
                if (s.UserName == UserName && s.UserPassword == Password && s.UserRole == Role)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                if (UserNameTex2.Text == "User Name" || UserPasswordtex2.Text == "Password" || UserPhoneno.Text != "Phone No")
                {
                    MessageBox.Show("Please Fill The Required Field");
                }
                else
                {
                    MuserDL.AddUserTOList(user);
                    MuserDL.StoreinFile(user);
                    MessageBox.Show("Your are Successfully Registered","Confirmation!",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Your are Not Eligible Try Another User Name", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            UserNameTex2.Clear();
            UserPasswordtex2.Clear();
            RolecomboBox2.Text = "Role";
            UserPhoneno.Clear();
            UserNameTex2.Focus();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SignInForm form = new SignInForm();
            form.Show();
            this.Hide();
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {

        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            SignInForm form = new SignInForm();
            form.Show();
            this.Hide();
           
        }

        private void visibleeyebutton_Click(object sender, EventArgs e)
        {
            if ( UserPasswordtex2.PasswordChar == '*')
            {
                //invisibleeyebtn.BringToFront();
                UserPasswordtex2.PasswordChar = '\0';
            }

        }

        private void invisibleeyebtn_Click(object sender, EventArgs e)
        {
            if (UserPasswordtex2.PasswordChar == '\0')
            {
               // visibleeyebutton.BringToFront();
                UserPasswordtex2.PasswordChar = '*';
            }
        }

        private void invisblebtn_Click(object sender, EventArgs e)
        {
            if (UserPasswordtex2.PasswordChar == '\0')
            {
                visiblebtn.BringToFront();
                UserPasswordtex2.PasswordChar = '*';
            }
        }

        private void visiblebtn_Click(object sender, EventArgs e)
        {
            if (UserPasswordtex2.PasswordChar == '*')
            {
                invisblebtn.BringToFront();
                UserPasswordtex2.PasswordChar = '\0';
            }
        }
    }
 }

