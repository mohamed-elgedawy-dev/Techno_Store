using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    internal class Order: BaseClass
    {

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public decimal SubTotal { get; set; }

        public decimal TaxRate { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }




        public void AddItem (OrderItem item)
        {
            
            Items.Add(item);
        }




    }
}
