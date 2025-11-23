using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Techno_Store.Domain;
using Techno_Store.NewFolder;

namespace Techno_Store.Services
{
    public class ProductServices
    {






        private readonly AppDbContext _context;

        public ProductServices(AppDbContext context)
        {
            _context = context;
        }

        public Product CreateProduct( string name, decimal price, int stock)
        {
            var product = new Product(name, price, stock);

            _context.Products.Add(product);
            _context.SaveChanges();   

            return product;
        }
    }
}
