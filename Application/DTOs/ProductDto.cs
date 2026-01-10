using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.DTOs
{
    public class ProductDto 
    {

        public int Id { get; init; }

        public required string Name { get;  set; }

        public decimal Price { get;  set; }

        public int Stock { get;  set; }

     
    }
}
