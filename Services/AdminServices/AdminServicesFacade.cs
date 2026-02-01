using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Data;

namespace Techno_Store.Services.AdminServices
{
    internal class AdminServicesFacade
    {
        public AdminProductServices AdminProductService { get; }
        public AdminOrderServices AdminOrderService { get; }
        public AdminCustomerServices AdminCustomerService { get; }

        public AdminServicesFacade(AppDbContext context)
        {
            
            var customerServices = new CustomerServices(context);
            var productServices = new ProductServices(context);
            var orderServices = new OrderServices(context);

            AdminCustomerService = new AdminCustomerServices(customerServices);
            AdminProductService = new AdminProductServices(productServices);
            AdminOrderService = new AdminOrderServices(orderServices);
        }




    }
}
