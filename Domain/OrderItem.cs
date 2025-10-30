using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    internal class OrderItem : BaseClass
    {
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal Total { get; private set; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            ProductId = product.Id;
            Quantity = quantity;
            Total = product.Price * quantity;
        }
    }
}
