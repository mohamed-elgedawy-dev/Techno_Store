using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Domain;
using Techno_Store.DTOs;

namespace Techno_Store.Application.Mapping
{
    public static class ProductMapping
    {

        public static ProductDto ToDto (Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };
        }

        public static Product ToDomain(ProductDto productDto)
        {
            return new Product(
                productDto.Name,
                productDto.Price,
                productDto.Stock
            );
        }



    }
}
