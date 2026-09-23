using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    public class Admin: BaseClass
    {
       
        public  string Name { get; private set; }
        public string Email { get; private set; }

        public bool HasPermission { get; private set; }

        public Admin( string name, string email, bool hasPermission)
        {
            
            Name = name;
            Email = email;
            HasPermission = hasPermission;
        }


    }
}
