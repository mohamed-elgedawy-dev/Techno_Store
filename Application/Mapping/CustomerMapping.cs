using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Domain;
using Techno_Store.DTOs;

namespace Techno_Store.Application.Mapping
{
    public static class CustomerMapping
    {


        public static CustomerDto ToDto (Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
            
                Name = customer.Name,


                Phone = customer.Phone,
                
            };
        }


    }
}
