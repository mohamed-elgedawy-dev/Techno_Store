using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class DataStor
    {

        public string filePath { get; } = Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\products.json");

        public List<Product> Products { get; set; } = new List<Product>();

        public DataStor()
        {

            string json = File.ReadAllText(filePath);
            Products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        public void SaveChanges(DataStor data)
        {
            string updatedJson = JsonSerializer.Serialize(data.Products);
            File.WriteAllText(filePath, updatedJson);

        }
    }
}

