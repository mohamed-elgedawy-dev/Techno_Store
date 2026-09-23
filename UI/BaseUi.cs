using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.DTOs;
using Techno_Store.Services;

namespace Techno_Store.UI
{
    public class BaseUi<TService>
    {
        protected readonly TService _Service;

        public BaseUi(TService service)
        {
            _Service = service;
        }


        public void DisplayProductsWithPagination(Func<List<ProductDto>> getProducts)
        {
            var products = getProducts();

            int pageSize = 5;
            int totalPages = (int)Math.Ceiling((double)products.Count / pageSize);
            int currentPage = 1;
            bool paging = true;

            while (paging)
            {
                Console.Clear();
                Console.WriteLine($"--- Product List Page {currentPage}/{totalPages} ---");

                var pageItems = products.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

                for (int i = 0; i < pageItems.Count; i++)
                {
                    var p = pageItems[i];
                    Console.WriteLine($"{i + 1}. ID: {p.Id}, Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}");
                }

                Console.WriteLine("\nN: Next | P: Previous | 0: Exit Pagination");
                var input = Console.ReadLine()?.ToUpper();

                switch (input)
                {
                    case "N":
                        if (currentPage < totalPages) currentPage++;
                        break;
                    case "P":
                        if (currentPage > 1) currentPage--;
                        break;
                    case "0":
                        paging = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, press Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }
        }

    }
}
