using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    public class Customer : BaseClass
    {
        public string Name { get; private set; }

        public string Phone { get; private set; }

        public Customer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        internal void Update(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
