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

        private List<OrderItem> _items { get; set; } = new List<OrderItem>();

        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();

        public Customer Customer { get; private set; }

        public int CustomerId { get; private set; }

        public decimal SubTotal { get; private set; }

        

        public decimal Tax { get; private set; }

        public decimal Total { get; private set; }

        private Order()
        {
            
        }
        public Order(Customer customer)
        {
            Customer = customer;
            CustomerId = customer.Id;
        }
        public OrderItem AddItem(Product product, int quantity)
        {
            var item = new OrderItem(product, quantity,this);
            _items.Add(item);
            CalculateTotals();
            return item;
        }

        public void CalculateTotals()
        {
            SubTotal = Items.Sum(i => i.Total);
            Tax = SubTotal * TaxRate;
            Total = SubTotal + Tax;
        }
    }
}
