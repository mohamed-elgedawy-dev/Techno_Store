using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.DTOs
{
    public class OrderDto 
    {

        public int Id { get; set; }



        public List<OrderItemDto> Items { get; set; } = new();



        public string? CustomerName { get;  set; }

        public int CustomerId { get;  set; }

        public decimal SubTotal { get;  set; }

        

        public decimal Tax { get;  set; }

        public decimal Total { get;  set; }

    
    }
}
