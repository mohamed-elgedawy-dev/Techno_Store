using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    public class OrderItem : BaseClass
    {
        public int ProductId { get; private set; }

        public Product Product { get; private set; }
        public int OrderId { get; private set; }

        public Order Order { get; private set; }
       
        public int Quantity { get; private set; }
        public decimal Total { get; private set; }
        private OrderItem()
        {
            
        }
        public OrderItem(Product product, int quantity , Order order )
        {
            Product = product;
            ProductId = product.Id;
            Order = order;
            OrderId = Order.Id;
            Quantity = quantity;
            Total = product.Price * quantity;
        }
    }
}
