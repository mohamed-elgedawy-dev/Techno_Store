// Ignore Spelling: Validator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Techno_Store
{
    internal   class InputValidator
    {

        public static int? AskForValidProductId(List<int>? validIds = null)
        {
            while (true)
            {
                Console.Write("Enter Product ID (or type 'x' to quit): ");
                string? input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(input) &&
                    input.Equals("x", StringComparison.OrdinalIgnoreCase))
                {
                    return null;
                }

                if (int.TryParse(input, out int id))
                {
                    if (id <= 0)
                    {
                        Console.WriteLine("ID must be a positive number.");
                        continue;
                    }

                    if (validIds == null)
                    {
                        return id;
                    }

                    
                    if (validIds.Contains(id))
                    {
                        return id;
                    }
                    else
                    {
                        Console.WriteLine("This ID does not exist in the available product list.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer or type 'x'.");
                }
            }
        }


        public static int? AskForPositiveInt(string message = "Enter a number (or type 'x' to quit): ")
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(input) &&
                    input.Equals("x", StringComparison.OrdinalIgnoreCase))
                {
                    return null;
                }

                if (int.TryParse(input, out int value))
                {
                    if (value > 0)
                        return value;

                    Console.WriteLine("Number must be positive.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }



       
    }

}

