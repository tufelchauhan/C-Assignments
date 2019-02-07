using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductsInventory proInventory = new ProductsInventory(); // Object  that maintains Product's Inventory

            proInventory.ProductList.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            proInventory.ProductList.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            proInventory.ProductList.Add(new Product("pumpkin", 30, 30, "Marrow"));
            proInventory.ProductList.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            proInventory.ProductList.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            proInventory.ProductList.Add(new Product("yam", 30, 50, "Root"));
            proInventory.ProductList.Add(new Product("spinach", 10, 100, "Leafy green"));
            proInventory.ProductList.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            proInventory.ProductList.Add(new Product("garlic", 30, 20, "Leafy green"));
            proInventory.ProductList.Add(new Product("silverbeet", 10, 50, "Marrow"));

            Console.WriteLine($"Total Number of Products : {proInventory.ProductList.Count}");

            Console.WriteLine("Adding Product");
            proInventory.ProductList.Add(new Product("Potato", 10, 50, "Root")); // Adding Product

            foreach (var pro in proInventory.getProductByType("Leafy green")) // using LINQ
            {
                Console.WriteLine(pro);
            }

            // alternative way without using LINQ
            //foreach(var pro in proInventory.ProductList)
            //{

            //    if (pro.Type.Equals("Leafy green"))
            //    {
            //        Console.WriteLine(pro);
            //    }
            //}

            proInventory.removeProduct("garlic");
            Console.WriteLine($"After Delete garlic Total Number of Products : {proInventory.ProductList.Count}");

            proInventory.addQuantity("cabbage", 50);

            Dictionary<string, int> buyProducts = new Dictionary<string, int>();
            buyProducts.Add("lettuce", 1);
            buyProducts.Add("zucchini", 2);
            buyProducts.Add("broccoli", 1);
            var TotalAmount = proInventory.purchaseProduct(buyProducts);
            Console.WriteLine($"Total Payable Amount : {Math.Round(TotalAmount)}");
        }
    }
}
