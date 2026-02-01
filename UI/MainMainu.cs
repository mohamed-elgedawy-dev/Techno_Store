using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Data;
using Techno_Store.Services;
using Techno_Store.Services.AdminServices;

namespace Techno_Store.UI
{
    internal class MainMainu
    {
        
       private readonly CustomerServicesFacade _customerServices;
        private readonly AdminServicesFacade _adminServices;




        public MainMainu( CustomerServicesFacade customerServices, AdminServicesFacade adminServices  )
        {
           
            _customerServices = customerServices;
            _adminServices = adminServices;


        }


        public void ShowMainMenu()
        {

         


            Console.WriteLine("====================================\r\n   Welcome to Techno Store \r\n====================================");

            Console.WriteLine("1. Login as Customer \n" +
                              "2. Login as Admin \n"+
                              "0. Exit");

            var choice = Convert.ToInt32(Console.ReadLine()); 
            if (choice == 1)
            {
              
                CustomerUI customerUI = new CustomerUI(_customerServices);
                customerUI.ShowProduct();


            }
            else if (choice == 2)
            {
                AdminUI adminUI = new AdminUI(_adminServices);
                adminUI.ShowAdminMenu();
            }
            else
            {
                Environment.Exit(0);
            }
           
        }

      
    }
}
