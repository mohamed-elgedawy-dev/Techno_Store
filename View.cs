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

        public void Display()
        {
            Data data = new Data();

            Console.WriteLine("{0,-5} | {1,-25} | {2,10} | {3,7}", "Id", "Name", "Price", "Stock");
            Console.WriteLine(new string('-', 55));

            foreach (var item in data.Products)
            {
                Console.WriteLine(
                    "{0,-5} | {1,-25} | {2,10:N2} | {3,7}",
                    item.Id,
                    item.Name,
                    item.Price,
                    item.Stock
                );
            }
        }

        public void TakingInputs(BillItem billItem)
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
            billItem.Produc.Id = id;

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

        public void TakingCustomerInfo(Person person)
        {
            Console.Write("Enter Customer Name: ");
            person.Name = Console.ReadLine();
            Console.Write("Enter Customer Phone: ");
            person.phone = Console.ReadLine();
            Console.Write("Enter Customer Email: ");
            person.Email = Console.ReadLine();
            Console.Write("Enter Customer Address: ");
            person.Address = Console.ReadLine();
        }

        public void PrintBill(Bill bill)
        {
            #region Print Bill
            Console.Clear();

            Console.WriteLine("=========== 🧾 Bill ===========");
            Console.WriteLine(
                "{0,-25} | {1,10} | {2,8} | {3,12}",
                "Product",
                "Price",
                "Qty",
                "Total"
            );
            Console.WriteLine(new string('-', 65));

            foreach (var item in bill.BillList)
            {
                Console.WriteLine(
                    "{0,-25} | {1,10:N2} | {2,8} | {3,12:N2}",
                    item.Produc.Name,
                    item.ItemPrice,
                    item.Amount,
                    item.Total
                );
            }

            decimal grandTotal = bill.BillList.Sum(i => i.Total);

            Console.WriteLine(new string('-', 65));
            Console.WriteLine($"Grand Total: {grandTotal:N2}");
            #endregion
        }
    }
}
// Added for full review PR
