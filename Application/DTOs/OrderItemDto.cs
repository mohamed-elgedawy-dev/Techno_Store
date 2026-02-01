using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.DTOs
{
    public class OrderItemDto 
    {
        
        public int Id { get; set; }

        public int ProductId { get;  set; }

        public required string Product { get;  set; }
        public int OrderId { get; set; }       
        public int Quantity { get;  set; }
        public decimal Total { get;  set; }

        public decimal Price { get; set; }

    }
}
