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
    internal class CustomerServices
    {

        private readonly AppDbContext _context;


        public CustomerServices( AppDbContext context)
        {
            _context = context;
        }



        public CustomerDto GetById(int customerId)
        {
            var customer = _context.Customers.Find(customerId);

            if (customer == null)
                return null!;
            return CustomerMapping.ToDto(customer);


        }

        public List<CustomerDto> GetAll()
        {
            var customers = _context.Customers.ToList();
            return customers.Select(c => CustomerMapping.ToDto(c)).ToList();
        }


        public CustomerDto AddCustomer (string name , string phone) 
        {
              Customer customer = new Customer(name, phone);

                _context.Customers.Add (customer);
                _context.SaveChanges();
                return CustomerMapping.ToDto(customer);


        }

        public void DeleteCustomer ( int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer == null)
                return;
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public CustomerDto UpdateCustomer ( int customerId , string newName , string newphone)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer == null)
                return null;
            customer.Update( newName, newphone);

            _context.SaveChanges();
            return CustomerMapping.ToDto(customer);
        }



















    }
}
