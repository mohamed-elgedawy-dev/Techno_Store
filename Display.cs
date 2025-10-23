using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Data;
using Techno_Store.Interfaces;

namespace Techno_Store
{
    internal class Display : IDisplay
    {
        public void DisplayData(DataServices data)
        {
            Console.WriteLine("{0,-5} | {1,-25} | {2,10} | {3,7}", "Id", "Name", "Price", "Stock");
            Console.WriteLine(new string('-', 55));

            foreach (var item in data.GetAllProduct())
            {
                if (item.Stock > 0)
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
        }

        public void ShowBill(List<BillItem> bill, decimal? grandTotal)
        {
            Console.Clear();

            Console.WriteLine("=========== Bill ===========");
            Console.WriteLine(
                "{0,-25} | {1,10} | {2,8} | {3,12}",
                "Product",
                "Price",
                "Qty",
                "Total"
            );
            Console.WriteLine(new string('-', 65));

            foreach (var item in bill)
            {
                Console.WriteLine(
                    "{0,-25} | {1,10:N2} | {2,8} | {3,12:N2}",
                    item.ProductName,
                    item.Price,
                    item.Amount,
                    item.Total
                );
            }

            Console.WriteLine(new string('-', 65));
            Console.WriteLine($"Grand Total: {grandTotal:N2}");
        }
    }
}
