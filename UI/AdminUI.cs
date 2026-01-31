using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Services.AdminServices;

namespace Techno_Store.UI
{
    internal class AdminUI
    {

        private readonly AdminServicesFacade _adminServices;


        public AdminUI(AdminServicesFacade adminServices)
        {
            _adminServices = adminServices;

        }


        public void ShowAdminMenu()
        {
            Console.WriteLine("====================================\r\n   Admin Panel \r\n====================================");
            Console.WriteLine("1. Manage Customer \n" +
                              "2. Manage Products \n" +
                              "0. Exit");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                CustomerAdminList();
            }


        }






        public void CustomerAdminList()
        {
            Console.WriteLine("====================================\r\n   Customer List \r\n====================================");
            Console.WriteLine("1. Customer Data List \n" +
                              "2. Delete Customer \n" +
                              "3. Update Customer \n" +
                              "0. Exit");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                CustomerDataList();


            }

            else if (choice == 2)
            
            {
                Console.WriteLine("enter customer id");
                int id = Convert.ToInt32(Console.ReadLine());

                CustomerDelete(id);

            }

        }

        private void CustomerDelete(int id)
        {
            _adminServices.AdminCustomerService.Delete(id);
        }

        private void CustomerDataList()
        {
            var customers = _adminServices.AdminCustomerService.GetAll();
            Console.WriteLine("----- Customer List -----");

            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Phone: {customer.Phone}");
            }
        }


    }
}
