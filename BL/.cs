using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalmartDesktopAPP.BL
{
    public class CustomerBL : Muser
    {
        private int bill;
       
        private List<ProductBL> buyProduct;
        
        public CustomerBL(string customerName, string Passsword, string Role,string PhoneNo,int bill, List<ProductBL> buyProduct):base(customerName,Passsword,Role,PhoneNo)
        {
            MessageBox.Show("Constructer Created");
             Bill = bill;
             BuyProduct = buyProduct;
        }
        public int Bill { get => bill; set => bill = value; }
        public List<ProductBL> BuyProduct { get => buyProduct; set => buyProduct = value; }
    }
}
