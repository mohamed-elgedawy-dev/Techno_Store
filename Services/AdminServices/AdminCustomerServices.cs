using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.DTOs;

namespace Techno_Store.Services.AdminServices
{
    internal class AdminCustomerServices
    {

        private readonly CustomerServices _customerServices;

        public AdminCustomerServices(CustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        public CustomerDto Add(string name , string  phone)
        {
            return _customerServices.AddCustomer(name , phone);
        }

        public void Delete(int id)
        {
            _customerServices.DeleteCustomer(id);
        }


        public List<CustomerDto> GetAll()
        {
            return _customerServices.GetAll();
        }


        public CustomerDto GetById(int id)
        {
            return _customerServices.GetById(id);
        }


        public CustomerDto Update(int id, string name, string phone)
        {
            return _customerServices.UpdateCustomer(id, name, phone);
        }





    }
}
