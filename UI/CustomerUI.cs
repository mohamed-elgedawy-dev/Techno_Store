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


        public CustomerDto GetOrCreateCustomer ()
        {
            Console.WriteLine("Enter your phone number:");
            var phone = Console.ReadLine();

            var existingCustomer = _Service.CustomerService.GetCustomerByPhone(phone!);

            if (existingCustomer!=null)
            {
                Console.WriteLine($"Welcome back, {existingCustomer.Name}!");
                return existingCustomer;
            }

            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
          
            var customer = _Service.CustomerService.AddCustomer(name!, phone!);
            return customer;
        }


        public void ShowCart()
        {bool ordering = true;
            int productId = 0;
            int quantity = 0;

            var order = _Service.OrderService.CreateOrder(GetOrCreateCustomer().Id);
            do
            {
                Console.WriteLine("chose the product id");
                 productId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("chose the quantity");
                 quantity = Convert.ToInt32(Console.ReadLine());
                

               

                Console.WriteLine("tape 1 to order 2 to bill");
                var choice = Convert.ToInt32(Console.ReadLine());

                 ordering = choice == 1;

              order=  _Service.OrderService.addOrderItem(order.Id, productId, quantity);

                _Service.ProductService.ReduceProductStock(productId, quantity);
            }
            while (ordering);

            _Service.OrderService.printBill(order);




        }
    }
}