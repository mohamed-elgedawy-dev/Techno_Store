using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class BillSave
    {
        private Bill bill;
        public BillSave()
        {
            
        }
        public BillSave(List<BillItem> list, decimal grandTotal)
        {
            string customerName = list[0].CustomerName ?? "Unknown";

            
            string fileName = $"{customerName}.json";

            var dataToSave = new
            {
                Items = list,
                GrandTotal = grandTotal
            };


            string json = JsonSerializer.Serialize(dataToSave, new JsonSerializerOptions { WriteIndented = true });

            
            File.WriteAllText(fileName, json);



        }

     
    }
}
// Added for full review PR
