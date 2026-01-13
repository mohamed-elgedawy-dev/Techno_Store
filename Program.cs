using Microsoft.EntityFrameworkCore;
using Techno_Store.Data;
using Techno_Store.Services;
using Techno_Store.Services.AdminServices;

namespace Techno_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {





            var context = new AppDbContext();
            var productServices = new ProductServices(context);

            AdminProductServices admin = new AdminProductServices(productServices);

          var p= admin.GetAll();
            foreach  (var item in p)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Price} - {item.Stock}");
            }







        }
    }
}
