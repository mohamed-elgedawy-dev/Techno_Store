using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class BillItem
    {
        public Product Produc { get; set; }

        public int Amount { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal Total => ItemPrice * Amount;
    }
}
// Added for full review PR
