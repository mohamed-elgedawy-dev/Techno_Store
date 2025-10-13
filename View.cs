using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Techno_Store.Interfaces;

namespace Techno_Store.Data
{
    internal class View : Iinfo
    {
      public Product Product = new Product();

        public string? CustomerName { get; set; }

        public int? ItemAmount { get; set; }
        public decimal? Price { get; set; }

        public decimal? Total { get; set; }


        int? choice;



        public int? TakingId(DataStor data)
        {
            List<int> productIds = data.Products
                              .Where(p => p.Stock > 0)
                              .Select(p => p.Id)
                              .ToList();
            var idInput = InputValidator.AskForValidProductId(productIds);
            if (idInput != null)

            {

                Product = data.Products.First(p => p.Id == idInput);

                Console.WriteLine($"Selected product: {Product.Name},  Price: {Product.Price}");

                return idInput;

            }
            else            
                return null;
        
        }


        public void TakingAmount()
        {
            if (Product == null)
            {
                Console.WriteLine("No product selected!");
                return;
            }

            int? amount = null;

            while (true)
            {

                amount = InputValidator.AskForPositiveInt("Enter product amount (or 'x' to cancel): ");

                if (amount == null)
                {
                    Console.WriteLine("Operation cancelled.");
                    return;
                }


                if (amount > Product.Stock)
                {
                    Console.WriteLine($"Insufficient stock! Only {Product.Stock} items available.");

                    do
                    {
                        choice = InputValidator.AskForPositiveInt("Do you want to (1) enter another amount or (2) cancel this product): ");
                    }
                    while (choice != 1 && choice != 2);

                    if (choice == 2)
                    {
                        Console.WriteLine("Product selection canceled.");
                        return;
                    }

                    continue; 
                }

                else
                {
                    ItemAmount = amount.Value;
                    Price = Product.Price;
                    break; 
                }
            }

           
        }


        public string TakingName()
        {
            string? name;

            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine(" Name cannot be empty, please enter a valid name.");
                }
                else if (name.Any(char.IsDigit))
                {
                    Console.WriteLine(" Name cannot contain numbers.");
                }
                else if (name.Length < 2)
                {
                    Console.WriteLine(" Name is too short.");
                }
                else
                {
                   
                    break;
                }
            }

            CustomerName = name!;
            Console.WriteLine($"Welcome, {name}!");
            return name!;
        }


        public bool AskToContinueOrFinish()
        {
            int id;

            while (true)
            {
                Console.WriteLine("\nPress 1 to add another order, or 2 to finish and see the bill:");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out id) && (id == 1 || id == 2))
                {
                    break;
                }

                Console.WriteLine("Invalid input! Please enter 1 or 2.");
            }
            Console.Clear();
            return id == 1;
        }
    }
}


