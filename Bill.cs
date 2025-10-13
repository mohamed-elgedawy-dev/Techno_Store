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
        public List<BillItem> BillList{ get;set;}= new List<BillItem>();
    }
}

