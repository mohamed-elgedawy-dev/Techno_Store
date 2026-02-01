using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.DTOs;
using Techno_Store.Services.AdminServices;

namespace Techno_Store.UI
{
    internal class AdminUI : BaseUi<AdminServicesFacade>
    {

        private readonly AdminServicesFacade _adminServices;


        public AdminUI(AdminServicesFacade adminServices) : base (adminServices)
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

            else if (choice == 2)
            {
                ProductAdminList();
            }
            if (choice == 0)
            {
                Console.WriteLine("Exiting program. Goodbye!");
                Environment.Exit(0); // يغلق البرنامج
            }


        }

        private void ProductAdminList()
        {
            Console.WriteLine("====================================\r\n   Customer List \r\n====================================");
            Console.WriteLine("1. Product Data List \n" +
                              "2. Delete Product \n" +
                              "3. Update Product \n" +
                               "4. Add Product \n" +
                              "0. Exit");
            var choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                ProductDataList();

            }

            else if (choice == 2)
            {
                Console.WriteLine("enter product id");
                int id = Convert.ToInt32(Console.ReadLine());
                _adminServices.AdminProductService.Delete(id);

                Console.WriteLine("product deleted");
            }
            else if (choice == 3)
            {
                ProductUpdate();
            }
      

            else if (choice == 4)
            {
                AddProduct();
            }
        }




        #region customer admin region
        private void CustomerAdminList()
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

            else if (choice == 3)
            {
                UpdateCustomer();
            }

            if (choice == 0)
            {
                Console.WriteLine("Exiting program. Goodbye!");
                Environment.Exit(0); // يغلق البرنامج
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


        private void UpdateCustomer()
        {
            Console.WriteLine("Enter Customer ID to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter new Phone:");
            string phone = Console.ReadLine();
            _adminServices.AdminCustomerService.Update(id, name, phone);
            
            Console.WriteLine("Customer updated successfully.");


        }
        #endregion


        private void ProductDataList()
        {
            DisplayProductsWithPagination(_Service.AdminProductService.GetAll);
        }


        private void ProductUpdate()
        {
            Console.WriteLine("Enter Product ID to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter new Price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter new stock");
            int stock = Convert.ToInt32(Console.ReadLine());
            var product = new ProductDto {  Id = id, Name = name, Price = price, Stock = stock };
            _adminServices.AdminProductService.Update( product);
            Console.WriteLine("Product updated successfully.");

        }


        private void AddProduct()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Product Stock:");
            int stock = Convert.ToInt32(Console.ReadLine());
            var product = new ProductDto { Name = name, Price = price, Stock = stock };
            _adminServices.AdminProductService.Add(product);
            Console.WriteLine("Product added successfully.");

        }



        }
}
