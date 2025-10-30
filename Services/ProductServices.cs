using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Techno_Store.Domain;

namespace Techno_Store.Services
{
    internal class ProductServices
    {
        public HttpClient HttpClient { get; private set; } = new HttpClient();

        public async Task<List<Product>?> GetProductsAsync()
        {
            string url = "https://fakestoreapi.com/products";
            string json = await HttpClient.GetStringAsync(url);

            var apiProducts = JsonSerializer.Deserialize<List<ApiProduct>>(
                json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            if (apiProducts == null)
                return new List<Product>();

            var products = apiProducts
                .Select(p => new Product(p.Id, p.Title, (decimal)p.Price, 50))
                .ToList();

            return products;
        }

        private class ApiProduct
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public decimal Price { get; set; }
        }
    }
}
