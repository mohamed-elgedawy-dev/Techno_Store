using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Techno_Store.Application.interfaces;
using Techno_Store.Data;
using Techno_Store.Domain;
using Techno_Store.DTOs;
using static Azure.Core.HttpHeader;

namespace Techno_Store.Services.AdminServices
{
    internal class AdminProductServices : IAdminServices<ProductDto>
    {
        private readonly ProductServices _productServices;


        public AdminProductServices( ProductServices productServices)
        {
            

            _productServices = productServices;
       

        }

        public ProductDto Add(ProductDto dto)
        {
            return _productServices.CreateProduct(dto.Name, dto.Price, dto.Stock);
        }

        public List<ProductDto> GetAll()
        {
            return _productServices.GetAllProducts();
        }

        public ProductDto GetById(int id)
        {
            return _productServices.GetProductById(id);
        }

        public void Update(ProductDto dto)
        {
            _productServices.UpdateProduct(dto.Id, dto.Name, dto.Price, dto.Stock);
        }

        public void Delete(int id)
        {
            _productServices.DeleteProduct(id);
        }
    }
}
