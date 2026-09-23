using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Domain;
using Techno_Store.DTOs;

namespace Techno_Store.Services.AdminServices
{
    internal class AdminOrderServices 
    {


        private readonly OrderServices _orderServices;
    


        public AdminOrderServices( OrderServices orderServices )
        { 
             _orderServices = orderServices;
           
        }   

        public OrderDto Add(int  customerId)
        { 
          
            return _orderServices.CreateOrder(customerId);

        }
         
        public void Delete(int id)
        {
            
            _orderServices.DeleteOrder(id);
        }

   

        public List<OrderDto> GetAll()
        {
            return _orderServices.GetAllOrders();
        }

        public OrderDto GetById(int id)
        {
            return _orderServices.GetOrder(id);
        }

        public OrderDto AddItem(int orderId, int productId, int quantity)
        {
            return _orderServices.addOrderItem(orderId, productId, quantity);
        }

    }
}
