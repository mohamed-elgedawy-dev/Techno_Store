using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    internal class Order: BaseClass
    {

        public List<OrderItem>? Items { get; set; }

    }
}
