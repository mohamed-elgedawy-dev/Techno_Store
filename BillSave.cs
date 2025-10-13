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
        public Bill bill = new Bill();

        public BillSave() { }

        public BillSave(Bill bill)
        {
            string fileName = $"{bill.customer.Name}.json";

            string json = JsonSerializer.Serialize(
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(fileName, json);
        }
    }
}
// Added for full review PR
