using Microsoft.EntityFrameworkCore;
using Techno_Store.NewFolder;
using Techno_Store.Services;

namespace Techno_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer("Server=DESKTOP-LUM6P28\\SQL2022;Database=TechnoStore;Trusted_Connection=True;TrustServerCertificate=True;")
    .Options;



            using var context = new AppDbContext(options);


            var productService = new ProductServices(context);

            productService.CreateProduct( "monitor", 2000, 15);



        }
    }
}
