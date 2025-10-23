using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Techno_Store.Entity;

namespace Techno_Store.Data
{
    internal class DataStore
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public DataStore(string filePath)
        {
            string json = File.ReadAllText(filePath);
            Products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        public void SaveChanges(DataPath filePath)
        {
            string updatedJson = JsonSerializer.Serialize(Products);
            File.WriteAllText(filePath.filePath, updatedJson);
        }
    }
}
