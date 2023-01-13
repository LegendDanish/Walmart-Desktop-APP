using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalmartDesktopAPP.BL;
using WalmartDesktopAPP.Path;
namespace WalmartDesktopAPP.DL
{
    public class MuserDL
    {
        //
        //List Of Users
        //
        private static List<Muser> user = new List<Muser>();
        //
        //gettter Settter
        //
        internal static List<Muser> User { get => user; set => user = value; }
        //
        //Check While Signin 
        //
        public static Muser Signin(Muser user)
        {
            foreach (Muser SUser in User)
            {
                if (SUser.UserName == user.UserName && SUser.UserPassword == user.UserPassword)
                {
                    return SUser;
                }
            }
            return null;
        }
        //
        // Load Users Form file
        //
        public static bool ReadData(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string UserName = splittedRecord[0];
                    string UserPassword = splittedRecord[1];
                    string UserRole = splittedRecord[2];
                    string UserPhoneNo = splittedRecord[3];
                    Muser user = new Muser(UserName, UserPassword, UserRole,UserPhoneNo);
                    AddUserTOList(user);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }
        //
        // Store User While Sign Up
        //
        public static void StoreinFile(Muser user)
        {
            StreamWriter file = new StreamWriter(UserId.UserIDPath, true);
            file.WriteLine(user.UserName + "," + user.UserPassword + "," + user.UserRole + "," + user.PhoneNo);
            file.Flush();
            file.Close();
        }

        //
        // After Update Store All Users
        //
        public static void StoreAllUserinFile()
        {
            StreamWriter file = new StreamWriter(UserId.UserIDPath, false);
            foreach (Muser user in User)
            {
                file.WriteLine(user.UserName + "," + user.UserPassword + "," + user.UserRole + "," + user.PhoneNo);
            }
                file.Flush();
                file.Close();
        }
        //
        // Add User To List
        //
        public static void AddUserTOList(Muser user)
        {
            User.Add(user);
        }
        //
        // For Get Customer Detail
        //
        public static Muser GetCustomerDetail(string Name)
        {
            foreach(Muser user in User)
            {
                if(user.UserName == Name)
                {
                    return user;
                }
            }
            return null;
        }

        //
        // For Change Account Check Validation
        //
        public static bool ChangeUserAccount(Muser Previous, Muser New)
        {
            int count = 0;
            foreach(Muser user in User)
            {
                if(user.UserName == Previous.UserName && user.UserPassword == Previous.UserPassword)
                {
                    user.UserName = New.UserName;
                    user.UserPassword = New.UserPassword;
                    count++;   
                }
            }
            if(count == 1)
            {
                return true;
            }
            return false;         
        }
        //
        // Update Account of Both Admin And Customer
        //
        public static void UpdateAdmininList(string Name,string Role)
        {
            foreach(Muser user in User)
            {
                if(user.UserName == Name)
                {
                    if(user.UserRole == "Admin")
                    {
                        
                    }
                }
            }
        }
    }
}

