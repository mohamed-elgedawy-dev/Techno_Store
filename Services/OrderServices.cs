using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Application.Mapping;
using Techno_Store.Data;
using Techno_Store.Domain;
using Techno_Store.DTOs;


namespace Techno_Store.Services
{
    public class OrderServices 
    {

        private readonly AppDbContext _context;


        public OrderServices(AppDbContext context)
        {
            _context = context;
        }


        public OrderDto CreateOrder(int customerId)
        {

            var customer = _context.Customers.Find(customerId);
            if (customer == null)
                return null;

            var order = new Order(customer);
            _context.Orders.Add(order);
            _context.SaveChanges();
            return OrderMapping.ToDto(order);



        }



        public void DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public OrderDto GetOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null)
                return null;

            return OrderMapping.ToDto(order);
        }

        public List<OrderDto> GetAllOrders()
        {
            var orders = _context.Orders.ToList();
            return orders.Select(OrderMapping.ToDto).ToList();
        }


        public OrderDto addOrderItem(int id, int productId, int quantity)
        {
            var order = _context.Orders.Find(id);
            if (order == null)
                return null;
            var product = _context.Products.Find(productId);
            if (product == null)
                return null;
            order.AddItem(product, quantity);

            _context.SaveChanges();

            return OrderMapping.ToDto(order);

        }

        public void deleteOrderItem(int orderItemId)
        {
            var orderItem = _context.OrderItems.Find(orderItemId);
            if (orderItem == null)
                return;
            _context.OrderItems.Remove(orderItem);
            _context.SaveChanges();
        }


        public void printBill(OrderDto order)
        {
           
            if (order == null)
                return;
            Console.WriteLine("----- Bill -----");
            Console.WriteLine($"Order ID: {order.Id}");
            Console.WriteLine($"Customer: {order.CustomerName}");
            Console.WriteLine("Items:");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"- {item.Product.ToString()} x{item.Quantity} @ {item.Price} = {item.Total}");
            }
            Console.WriteLine($"Subtotal: {order.SubTotal}");
            Console.WriteLine($"Tax: {order.Tax}");
            Console.WriteLine($"Total: {order.Total}");
            Console.WriteLine("----------------");
        }




    }
}
