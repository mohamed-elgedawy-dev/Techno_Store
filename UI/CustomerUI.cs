using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Data;
using Techno_Store.DTOs;
using Techno_Store.Services;

namespace Techno_Store.UI
{

   

    public class CustomerUI
    {
        private readonly CustomerServicesFacade _Service;


        public CustomerUI(CustomerServicesFacade Service)
        {
           
            _Service = Service;
        }


        public void ShowProduct()
        {

          

         _Service.ProductService.GetAllProducts().ForEach(p =>
            {
                Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}");
            });
            ShowCart();

        }


        public void ShowCart()
        {
            Console.WriteLine("chose the product id");
            var productId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("chose the quantity");
            var quantity = Convert.ToInt32(Console.ReadLine());
         var product=   _Service.ProductService.GetProductById(productId);

            _Service.ProductService.ReduceProductStock(product, quantity);



        }
    }
}