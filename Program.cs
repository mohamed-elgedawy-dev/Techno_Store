using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Techno_Store.Data;
using Techno_Store.Services;
using Techno_Store.Services.AdminServices;
using Techno_Store.UI;

namespace Techno_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();


            AdminServicesFacade adminServices = new AdminServicesFacade( context );
            CustomerServicesFacade customerServices = new CustomerServicesFacade( context );



            MainMainu mainMainu = new MainMainu( customerServices, adminServices );
            mainMainu.ShowMainMenu();
            




        }
    }
}
