using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Domain
{
    internal class Customer: BaseClass
    {
        public string? Name { get; set; }

        public string? Phone { get; set; }

        public Customer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public override string ToString() => $"{Id, -5} | {Name, -20} | {Phone}";
    }
}
