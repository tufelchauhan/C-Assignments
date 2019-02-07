using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string name, double price, int quantity, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return $"Name : {this.Name} | Price : {this.Price} | Quantity : {this.Quantity} | Type : {this.Type}";
        }
    }
}
