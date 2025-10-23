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

        public BillSave() { }

        public BillSave(List<BillItem> list, string CustomerName, decimal? grandTotal)
        {
            string customerName = CustomerName ?? "Unknown";

            string fileName = $"{customerName}.json";

            var dataToSave = new
            {
                Items = list,
                GrandTotal = grandTotal,
                Name = customerName,
            };

            string json = JsonSerializer.Serialize(
                dataToSave,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(fileName, json);
        }
    }
}
