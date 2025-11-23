using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    public class Order : BaseClass
    {

        private const decimal TaxRate = 0.15m;

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public decimal SubTotal { get; private set; }

        

        public decimal Tax { get; private set; }

        public decimal Total { get; private set; }

        public void AddItem(Product product, int quantity)
        {
            var item = new OrderItem(product, quantity);
            Items.Add(item);
            CalculateTotals();
        }

        public void CalculateTotals()
        {
            SubTotal = Items.Sum(i => i.Total);
            Tax = SubTotal * TaxRate;
            Total = SubTotal + Tax;
        }
    }
}
