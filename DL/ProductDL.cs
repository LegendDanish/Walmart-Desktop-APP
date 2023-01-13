using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalmartDesktopAPP.BL;
using WalmartDesktopAPP.GUI;
using WalmartDesktopAPP.Path;
namespace WalmartDesktopAPP.DL
{
    public class ProductDL
    {
        //
        //Product List
        //
        public static List<ProductBL> Products = new List<ProductBL>(); 
        //
        //Search Product List
        //
        public static List<ProductBL> SearchList = new List<ProductBL>();



        //
        // SearchProduct
        //
        public static List<ProductBL> GetSearchProductList(string Catagory)
        {

            SearchList.Clear();
            foreach (ProductBL product in ProductDL.Products)
            {
                if (product.Catagories == Catagory)
                {
                    ProductDL.SearchList.Add(product);
                }
            }
            return ProductDL.SearchList;
        }
        // Products Load From ProductFile //
        public static bool Loadproducts(string path)
        {
            Products.Clear();
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string CatagoryName = splittedRecord[0];
                    string ProductName = splittedRecord[1];
                    int ProductPrize = int.Parse(splittedRecord[2]);
                    int ProductQuantity = int.Parse(splittedRecord[3]);
                    int ProductDiscount = int.Parse(splittedRecord[4]);
                    ProductBL product = new ProductBL(CatagoryName, ProductName, ProductPrize, ProductQuantity, ProductDiscount);
                    AddProductToList(product);
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
        // Add Products To ProductList
        //
        public static void AddProductToList(ProductBL product)
        {
            Products.Add(product);
        }

        // Store Products in ProductFile//
        public static void StoreProductsInFile(ProductBL product)
        {
            StreamWriter file = new StreamWriter(ProductsPath.ProductPath, true);
            file.WriteLine(product.Catagories + "," + product.Products + "," + product.Prices + "," + product.Quantites + "," + product.Discounts);
            file.Flush();
            file.Close();
        }

        //
        //Store Product Information in File
        //
        public static void StoreAllDataInfile(string Path,List<ProductBL> Products)
        {
            StreamWriter file = new StreamWriter(Path);
            foreach (ProductBL product in Products)
            {
                file.WriteLine(product.Catagories + "," + product.Products + "," + product.Prices + "," + product.Quantites + "," + product.Discounts);
            }
            file.Flush();
            file.Close();
        }

        //
        //UpdateProduct
        //
        public static void UpdateProduct(string CatagoryName, string ProductName, ProductBL NewProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Catagories == CatagoryName && Products[i].Products == ProductName)
                {
                    Products[i] = NewProduct;
                }
            }
        }
        //
        //Valid Catagory
        //
        public static bool ValidCatagory(string Catagory)
        {
            foreach (ProductBL product in ProductDL.Products)
            {
                if (product.Catagories == Catagory)
                {
                    return true;
                }
            }
            return false;
        }

        //
        //DeleteProduct
        //
        public static void DeleteProduct(ProductBL prod)
        {
            for(int i=0; i<Products.Count; i++)
            {
                if (Products[i].Catagories == prod.Catagories && Products[i].Products == prod.Products)
                {
                    Products.RemoveAt(i);
                }
            }
        }
        //
        //CheckOfferProductValid
        //

        public static ProductBL CheckPRoductValid(string ProductName)
        {
            foreach(ProductBL product in Products)
            {
                if(product.Products == ProductName && product.Quantites > 0)
                {
                    return product;
                }
            }
            return null;
        }

        // 
        //CalculatePricewithDiscount
        //
        public static int CalculatePrice(ProductBL ordersBill)
        {
            return (ordersBill.Prices - (ordersBill.Prices * ordersBill.Discounts / 100)) * ordersBill.Quantites;

        }

        //
        //While Loading check product Exist
        //
        public static ProductBL isProductExist(string Product)
        {
            foreach(ProductBL prod in Products)
            {
                if(prod.Products == Product)
                {
                    return prod;
                }
            }
            return null;
        }
    }
}
