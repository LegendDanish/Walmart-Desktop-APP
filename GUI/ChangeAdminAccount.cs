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
    public partial class ChangeAdminAccount : UserControl
    {
        public ChangeAdminAccount()
        {
            InitializeComponent();
        }
        public void FieldClear()
        {
            PreviousNametxt.Clear();
            PreviousPasstxt.Clear();
            NewNametxt.Clear();
            NewPasswordtxt.Clear();
        }
        private void ResetAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PreviousNametxt.Text != "Previous UserName" || PreviousPasstxt.Text != "Previous Password" || NewNametxt.Text != "New UserName" || NewPasswordtxt.Text != "New Password")
                {
                    string PreviosName = PreviousNametxt.Text;
                    string PreviosPassword = PreviousPasstxt.Text;
                    string NewName = NewNametxt.Text;
                    string NewPassword = NewPasswordtxt.Text;
                    Muser Previous = new Muser(PreviosName, PreviosPassword);
                    Muser New = new Muser(NewName, NewPassword);
                    bool Confirm = MuserDL.ChangeUserAccount(Previous, New);
                    if(Confirm == true)
                    {
                        MessageBox.Show("Account Changed", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MuserDL.StoreAllUserinFile();
                        FieldClear();
                        WrongUserMessage.Clear();
                    }
                    if(Confirm == false)
                    {
                        WrongUserMessage.Text = "Invalid UserName And Password!";
                    }

                }
            }
            catch
            {
                MessageBox.Show("Please Fill The Required Filed","Ulert!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
