using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class View
    {
        public int ProductId { get; set; }

        public int ItemAmount { get; set; }

        public string? Name { get; set; }


        public void Display()
        {

           Data data = new Data();

           
            Console.WriteLine("{0,-5} | {1,-25} | {2,10} | {3,7}", "Id", "Name", "Price", "Stock");
            Console.WriteLine(new string('-', 55)); 

            
            foreach ( var item in data.Products)
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,10:N2} | {3,7}",
                   item.Id, item.Name, item.Price, item.Stock);
            }


            
        }


        public void TakingInputs()
        {
            int id;
            string? input;

           
            do
            {
                Console.Write("Enter product Id: ");
                input = Console.ReadLine();

                if (!int.TryParse(input, out id) || id < 1 || id > 20)
                {
                    Console.WriteLine("❌ Invalid input! Please enter a number between 1 and 20.");
                }

            } while (!int.TryParse(input, out id) || id < 1 || id > 20);

            ProductId = id;
            Console.WriteLine($"✅ You entered product Id: {ProductId}");

            
            int amount;
            string? _input;
            do
            {
                Console.Write("Enter product amount: ");
                _input = Console.ReadLine();

                if (!int.TryParse(_input, out amount) || amount <= 0)
                {
                    Console.WriteLine("❌ Invalid input! Please enter a positive number.");
                }

            } while (!int.TryParse(_input, out amount) || amount <= 0);

            ItemAmount = amount;
            Console.WriteLine($"✅ You entered Amount : {ItemAmount}");




          

        }

        public void TakingName()
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            // Validation
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty, please enter a valid name.");
            }
            else if (name.Any(char.IsDigit))
            {
                Console.WriteLine("Name cannot contain numbers.");
            }
            else if (name.Length < 2)
            {
                Console.WriteLine("Name is too short.");
            }
            else
            {
                Console.WriteLine($"Welcome, {name}!");
            }


            Name = name;
        }


    }
}
// Added for full review PR

