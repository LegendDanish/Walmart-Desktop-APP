using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalmartDesktopAPP.BL;
using WalmartDesktopAPP.Path;
using WalmartDesktopAPP.GUI;
using System.IO;
namespace WalmartDesktopAPP.DL
{
    public class CustomerDL
    {
        //
        // List Of Only One Customer Record
        //
        private static List<ProductBL> CustomerOrders = new List<ProductBL>();
        //
        // List Of All Customer Record
        //
        private static List<CustomerBL> Customers = new List<CustomerBL>();
        //
        //List Of Orders With Customer Name
        //
        private static List<SpecificCustomerBL> Customer = new List<SpecificCustomerBL>();
        
        //
        //Builtin Gettter Setter Function
        internal static List<ProductBL> CustomerOrders1 { get => CustomerOrders; set => CustomerOrders = value; }
        internal static List<CustomerBL> Customers1 { get => Customers; set => Customers = value; }
        public static List<SpecificCustomerBL> Customer1 { get => Customer; set => Customer = value; }

        //
        //Add Orders To List
        //
        public static void AddOrderToList(ProductBL orders)
        {
            CustomerOrders1.Add(orders);
        }

        //
        // For Add ALL Customer With Specific Orders
        public static void AddAllCustomerwithOrders(SpecificCustomerBL customer)
        {
            Customer1.Add(customer);
        }
        // 
        //Add All  Customers With Bills In List
        //
        public static void AddCustomersToList(CustomerBL customer)
        {
            Customers1.Add(customer);
        }
        //
        //Load Orders of Current Customer
        //
        public static bool LoadOrders(string Path,string Name)
        {
            CustomerOrders1.Clear();
            StreamReader file = new StreamReader(Path);
            string record;
            if (File.Exists(Path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string CustomerName = splittedRecord[0];
                    string CatagoryName = splittedRecord[1];
                    string ProductName = splittedRecord[2];
                    int ProductPrize = int.Parse(splittedRecord[3]);
                    int Quantity = int.Parse(splittedRecord[4]);
                    int Discount = int.Parse(splittedRecord[5]);
                    if (CustomerName == Name)
                    {
                        ProductBL product = new ProductBL(CatagoryName, ProductName, ProductPrize, Quantity, Discount);
                        AddOrderToList(product);
                    }
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        //
        //Check Orders Exist in Current Customer List
        //
        public static ProductBL isOrderExist(string Product)
        {
            foreach (ProductBL prod in CustomerOrders1)
            {
                if(prod.Products == Product)
                {
                    return prod;
                }
               
            }
            return null;
        }
        //
        //Load All customers With Bills And Orders
        //
        public static bool LoadCustomers(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    
                    string[] splittedRecord = record.Split(',');
                    string CustomerName = splittedRecord[0];
                    string Password = splittedRecord[1];
                    string Role = splittedRecord[2];
                    string PhoneNo = splittedRecord[3];
                    int Bill = int.Parse(splittedRecord[4]);
                    string[] splittedRecordForPreference = splittedRecord[5].Split(';');
                    LoadOrders(ProductsPath.OrdersPath, CustomerName);
                    List<ProductBL> products = new List<ProductBL>();
                    for (int x = 0; x < splittedRecordForPreference.Length; x++)
                    {
                        ProductBL prod = ProductDL.isProductExist(splittedRecordForPreference[x]);
                       
                        if (prod != null)
                        {
                            MessageBox.Show(CustomerName + prod.Products);
                            prod = isOrderExist(splittedRecordForPreference[x]);
                           
                            if (prod != null)
                            {
                                
                             // if (!(products.Contains(prod)))  
                                    products.Add(prod);
                               
                            }
                           
                         
                        }
                       
                        
                    }
                    CustomerBL customer = new CustomerBL(CustomerName, Password,Role,PhoneNo, Bill, products);
                    AddCustomersToList(customer);
                 }
                f.Close();
                return true;
            }
            else
                return false;
        }
        //
        //Store All Customers
        //
        public static void StoreCustomers()
        {
            string OrdersProduct = "";
            StreamWriter f = new StreamWriter(CustomerPath.CustomersPath);
            for (int i = 0; i < Customers.Count; i++)
            {
                
                for (int x = 0; x < Customers[i].BuyProduct.Count - 1; x++)
                {
                    OrdersProduct = OrdersProduct + Customers[i].BuyProduct[x].Products + ";";
                }
                OrdersProduct = OrdersProduct + Customers[i].BuyProduct[Customers[i].BuyProduct.Count - 1].Products;
                f.WriteLine(Customers[i].UserName + "," + Customers[i].UserPassword + "," + Customers[i].UserRole + "," + Customers[i].PhoneNo + "," + Customers[i].Bill + ","+ OrdersProduct);
                OrdersProduct = "";
            }
            f.Flush();
            f.Close();
        }
        //
        // Store Orders of Current Customer
        //
        public static void storeOrders(ProductBL product,string Name)
        {
            StreamWriter file = new StreamWriter(ProductsPath.OrdersPath, true);
            file.WriteLine(Name + "," + product.Catagories + "," + product.Products + "," + product.Prices + "," + product.Quantites + "," + product.Discounts);
            file.Flush();
            file.Close();
        }

        //
        // Store Customer Orders in File for Mapping
        //
        public static void StoreAllCustomersOrders()
        {
            StreamWriter file = new StreamWriter(ProductsPath.OrdersPath, false);
            foreach (SpecificCustomerBL customer in Customer1)
            {
                file.WriteLine(customer.Name1 + "," + customer.Catagories + "," + customer.Products + "," + customer.Prices + "," + customer.Quantites + "," + customer.Discounts);
            }
            file.Flush();
            file.Close();

        }
        //
        //Delete Orders before Generate Bill
        //
        public static void DeleteOrders(ProductBL product)
        {
            for(int i=0; i< CustomerOrders1.Count; i++)
            {
                if (CustomerOrders1[i].Catagories == product.Catagories && CustomerOrders1[i].Products == product.Products)
                {
                    CustomerOrders1.RemoveAt(i);
                }
            }
        }
        // 
        // For Assign Customer If Exist otherwise return for Add
        //
        public static CustomerBL AssignListToCustomer(List<ProductBL> prod, Muser Customer)
        {
            CustomerBL cust = new CustomerBL(Customer.UserName, Customer.UserPassword, Customer.UserRole, Customer.PhoneNo, GenerateBill.Bills, prod);
            int count = 0;
            
            for (int i=0; i<Customers1.Count; i++)
            {
              
                if (Customers1[i].UserName == Customer.UserName)
                {                  
                    Customers1[i].UserName = cust.UserName;
                    Customers1[i].UserPassword = cust.UserPassword;
                    Customers1[i].UserRole = cust.UserRole;
                    Customers1[i].PhoneNo = cust.PhoneNo;
                    Customers1[i].Bill = cust.Bill;
                    Customers[i].BuyProduct = cust.BuyProduct;
                    count++; 
                }
            }
            if(count == 0)
            {
                return cust;
            }
            return null;
        }

        //
        // Get Customer Object
        //
        public static CustomerBL GetCustomerObject(string Name)
        {
           foreach(CustomerBL customer in Customers)
            {
                if(customer.UserName == Name)
                {
                    return customer;
                }
            }
            return null;
        }
        //
        // Admin Full Fill Orders Form Current Customer List
        //
        public static void FullFillOrders(SpecificCustomerBL customer)
        {
            for(int i=0; i<Customer1.Count; i++ )
            {
                if (Customer1[i].Name1 == customer.Name1 && Customer1[i].Products == customer.Products)
                {
                    Customer1.RemoveAt(i);
                }
            }
        }

        //
        // Delete Customer From His Current List After Full Fill Orders
        //
        public static void DeleteCustomer(List<ProductBL> Product,ProductBL product,CustomerBL cust)
        {
            for(int i=0; i<Product.Count; i++)
            {
                foreach (ProductBL prod in ProductDL.Products)
                {
                    if (Product[i].Products == product.Products && prod.Products == product.Products)
                    {
                        cust.Bill = cust.Bill - (prod.Prices * product.Quantites);
                        Product.RemoveAt(i);

                    }
                }
            }
        }
        //
        // Load All Customer With Name For Mapping
        //
        public static bool LoadallCutomerOrders(string Path)
        {
            Customer1.Clear();
            StreamReader file = new StreamReader(Path);
            string record;
            if (File.Exists(Path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string CustomerName = splittedRecord[0];
                    string CatagoryName = splittedRecord[1];
                    string ProductName = splittedRecord[2];
                    int ProductPrize = int.Parse(splittedRecord[3]);
                    int Quantity = int.Parse(splittedRecord[4]);
                    int Discount = int.Parse(splittedRecord[5]);
                    SpecificCustomerBL orders = new SpecificCustomerBL(CustomerName,CatagoryName, ProductName, ProductPrize, Quantity, Discount);
                    AddAllCustomerwithOrders(orders);
                  
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
