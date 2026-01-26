using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Data;

namespace Techno_Store.Services
{
    public
        class CustomerServicesFacade
    {

        public ProductServices ProductService { get; }
        public CustomerServices CustomerService { get; }
        public OrderServices OrderService { get; }

        public CustomerServicesFacade(AppDbContext context)
        {
            ProductService = new ProductServices(context);
            CustomerService = new CustomerServices(context);
            OrderService = new OrderServices(context);
        }


    }
}
