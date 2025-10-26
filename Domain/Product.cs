using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    internal class Product : BaseClass
    {
        public string? Name { get; private set; }

        public decimal Price { get; private set; }

        public int Stock { get; private set; }


        public Product( int id, string name , decimal price , int stock )
        {
            
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public bool IsInStock(int quantity) 
        { 
            return Stock>= quantity;
        }

        public void DecreaseStock(int quantity)
        {
            Stock -= quantity;

        }

        public void IncreaseStock(int quantity)
        {
            Stock += quantity;
        }

        public override string ToString()
        {
            return $" Name: {Name}, Price: {Price}, Stock: {Stock}";
        }
    }
}
