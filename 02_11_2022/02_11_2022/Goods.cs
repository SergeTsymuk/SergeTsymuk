using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_11_2022
{
    internal class Goods
    {
        string productName = null;
        int quantity = 0;
        decimal price = 0;
        
        public string ProductName { get { return productName; } set { productName = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        
        public Goods(string ProductName)
        {
            productName = ProductName;
        }

    }
}
