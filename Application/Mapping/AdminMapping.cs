using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Domain;
using Techno_Store.DTOs;

namespace Techno_Store.Application.Mapping
{
    public static class AdminMapping
    {


        public static AdminDto ToDto (Admin admin)
        {
            return new AdminDto
            {
                Id = admin.Id,
                Name = admin.Name,
                Email = admin.Email,
                HasPermission = admin.HasPermission
            };
        }


    }
}
