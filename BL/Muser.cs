using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalmartDesktopAPP.BL
{
    public class Muser
    { 

        private string userName;
        private string userPassword;
        private string userRole;
        private string phoneNo;

        public Muser(string UserName, string UserPassword)
        {
           this.UserName = UserName;
           this.UserPassword = UserPassword;
        }
        public Muser(string userName, string userPassword, string userRole,string UserPhoneNo) : this(userName, userPassword)
        {
            PhoneNo = UserPhoneNo;
            UserRole = userRole;

        }

        public string UserName
        {
            get => userName; set
            {
                if (userName != "")
                {
                    userName = value;
                }
            }
        }
        public string UserPassword
        {
            get => userPassword; set
            {
                if (userPassword != "")
                {
                    userPassword = value;
                }
            }
        }
        public string UserRole
        {
            get => userRole; set
            {
                if (userRole != "")
                {
                    userRole = value;
                }
            }
        }

        public string PhoneNo { get => phoneNo; set => phoneNo = value; }

        public bool IsAdmin()
        {
            if (UserRole == "Admin")
            {
                return true;
            }
            return false;
        }

    }
}
