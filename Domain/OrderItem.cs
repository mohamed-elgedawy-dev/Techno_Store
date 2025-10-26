using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    internal class OrderItem : BaseClass
    {
        public int ProductId { get; set; }

        public Product? product { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get; set; }
    }
}
