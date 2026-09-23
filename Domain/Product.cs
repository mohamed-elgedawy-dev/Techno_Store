using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    public class Product : BaseClass
    {
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public int Stock { get; private set; }

        public Product( string name, decimal price, int stock)
        {
            
            Name = name;
            Price = price;
            Stock = stock;
        }

        public bool IsInStock(int quantity)
        {
            return Stock >= quantity;
        }

      

        public void UpdateStock(int quantity)
        {
            Stock = quantity;
        }

        public void UpdateDetails(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void ReduceStock(int quantity)
        {
            if (IsInStock(quantity))
            {
                Stock -= quantity;
            }
       
        }
    }
}
