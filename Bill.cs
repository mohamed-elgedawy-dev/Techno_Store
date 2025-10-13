using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class Bill
    {
        public List<BillItem> BillList { get; set; } = new List<BillItem>();

        public Customer customer { get; set; } = new Customer();

        public decimal GrandTotal => BillList.Sum(item => item.Total);
    }
}
// Added for full review PR
