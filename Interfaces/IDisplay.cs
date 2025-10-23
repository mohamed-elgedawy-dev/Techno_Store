using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Data;

namespace Techno_Store.Interfaces
{
    internal interface IDisplay
    {
        public void ShowBill(List<BillItem> bill, decimal? grandTotal);

        public void DisplayData(DataServices data);
    }
}
