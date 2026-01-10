using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.DTOs

{
    public class AdminDto 
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public bool HasPermission { get; set; }

   


    }
}
