using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Techno_Store.Application.Mapping;
using Techno_Store.Data;
using Techno_Store.Domain;
using Techno_Store.DTOs;


namespace Techno_Store.Services
{
    public class ProductServices
    {






        private readonly AppDbContext _context;

        public ProductServices(AppDbContext context)
        {
            _context = context;
        }



        public ProductDto CreateProduct( string name, decimal price, int stock)
        {
            var product = new Product(name, price, stock);

            _context.Products.Add(product);
            _context.SaveChanges();   

            return ProductMapping.ToDto(product)
            ;
        }



        public List<ProductDto> GetAllProducts()
        {
            var products = _context.Products.ToList();
            return products.Select(ProductMapping.ToDto).ToList();
        }


        public ProductDto GetProductById(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
          return null;

            return ProductMapping.ToDto(product);
        }



        public void ReduceProductStock(int productId, int newStock)
        {
           var product = _context.Products.Find(productId);
            if (product != null)
            {
                product.ReduceStock (newStock);
                _context.SaveChanges();
            }
        }





        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }



        public ProductDto UpdateProduct(int productId, string name, decimal price, int stock)
        {
            var product = _context.Products.Find(productId);
            if (product == null)
                return null;
            product.UpdateDetails(name, price, stock);
            _context.SaveChanges();
            return ProductMapping.ToDto(product);
        }
    }
}
