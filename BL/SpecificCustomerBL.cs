using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalmartDesktopAPP.BL
{
    //
    // I made this Class For Mapping Because I dont think there is no Another way of Mapping Without this Solution According To My situation
    // //
    public class SpecificCustomerBL : ProductBL
    {
        
       private string Name;
        public SpecificCustomerBL(string Name, string Catagory, string Product, int Price, int Quantity, int Discount) : base(Catagory,Product,Price,Quantity,Discount)
        {
            Name1 = Name;
        }
        public string Name1 { get => Name; set => Name = value; }
    }
}
