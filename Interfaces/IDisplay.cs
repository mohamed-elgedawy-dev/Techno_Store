using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Interfaces
{
    internal interface IDisplay
    {
        public decimal? ShowBill(Bill bill);

        public void DisplayData( Data data);
    }
}
