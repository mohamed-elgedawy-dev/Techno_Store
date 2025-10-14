using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class Data
    {
        public string filePath { get; } =
            Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\products.json");

        public List<Product> Products { get; set; } = new List<Product>();

        public Data()
        {
            string json = File.ReadAllText(filePath);
            Products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        public void SaveChanges(Data data)
        {
            string updatedJson = JsonSerializer.Serialize(data.Products);
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
