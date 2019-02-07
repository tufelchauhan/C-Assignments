using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class ProductsInventory
    {
        internal List<Product> ProductList;
        public ProductsInventory()
        {
            ProductList = new List<Product>();
        }

        public IEnumerable<Product> getProductByType(string val)
        {
            var ProductQueryByType = this.ProductList.Where(v => v.Type.Equals(val));
            return ProductQueryByType;
        }
        public void removeProduct(string name)
        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].Name.Equals(name))
                {
                    Console.WriteLine("executed");
                    this.ProductList.RemoveAt(i);
                    break;
                }
            }
        }
        public void addQuantity(string name, int qty)
        {
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].Name.Equals(name))
                {
                    ProductList[i].Quantity += qty;
                    Console.WriteLine($"Final Quantity of {ProductList[i].Name} = {ProductList[i].Quantity}");
                }
            }
        }

        internal double purchaseProduct(IDictionary<string, int> buypro)
        {
            double totalAmount = 0;
            foreach (var pro in buypro)
            {
                for (int i = 0; i < ProductList.Count; i++)
                {
                    if (ProductList[i].Name.Equals(pro.Key))
                    {
                        totalAmount += (ProductList[i].Price * pro.Value);
                    }
                }
            }
            return totalAmount;
        }
    }
}
