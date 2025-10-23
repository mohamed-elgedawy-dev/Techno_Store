using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class BillItem
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        public int? Amount { get; set; }

        public decimal? Price { get; set; }

        public decimal? Total { get; set; }
    }
}
