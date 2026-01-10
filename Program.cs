using Microsoft.EntityFrameworkCore;
using Techno_Store.Data;
using Techno_Store.Services;

namespace Techno_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {






            using var context = new AppDbContext();


           var products = context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }







        }
    }
}
