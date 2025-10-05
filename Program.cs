namespace Techno_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialization
            int repeat;
            Orders order = new Orders();
            View view = new View();
            Bill bill = new Bill();
            decimal lineTotal = 0;
            #endregion





            #region Take Customer Name
            view.TakingName();
            #endregion








            #region Orders Loop
            do
            {
                Console.Clear();

                #region Display Products
                view.Display();
                var product = new Product();
                #endregion





                #region Input Validation (Check stock)
                do
                {
                    view.TakingInputs();

                    Data data = new Data();
                    product = data.Products.Find(p => p.Id == view.ProductId);

                    if (view.ItemAmount > product.Stock)
                    {
                        Console.WriteLine($"❌ Only {product.Stock} items available.");
                    }

                } while (view.ItemAmount > product.Stock);
                #endregion








                #region Create Order
                order.MakingOrder(view.ProductId, view.ItemAmount);

                lineTotal = product.Price * view.ItemAmount;

                bill.BillList.Add(new BillItem
                {
                    ProductName = product.Name,
                    Amount = view.ItemAmount,
                    Price = product.Price,
                    CustomerName = view.Name,
                    Total = lineTotal


                });

                order.SaveChanges();
                #endregion






                #region Ask to Continue or Finish
                Console.WriteLine("Press 1 to add another order, or 2 to finish and see the bill");

                string? input = Console.ReadLine();

                int id;
                while (!int.TryParse(input, out id) || (id != 1 && id != 2))
                {
                    Console.WriteLine("❌ Invalid input! Please enter a valid number.");
                    Console.Write("Press 1 to add another order, or 2 to finish and see the bill : ");
                    input = Console.ReadLine();
                }

                repeat = id;
                #endregion





            } while (repeat == 1);

            #endregion






            #region Print Bill
            Console.Clear();

            Console.WriteLine("=========== 🧾 Bill ===========");
            Console.WriteLine("{0,-25} | {1,10} | {2,8} | {3,12}", "Product", "Price", "Qty", "Total");
            Console.WriteLine(new string('-', 65));

            foreach (var item in bill.BillList)
            {
                lineTotal = item.Price * item.Amount;
                Console.WriteLine("{0,-25} | {1,10:N2} | {2,8} | {3,12:N2}",
                    item.ProductName, item.Price, item.Amount, lineTotal);
            }

            decimal grandTotal = bill.BillList.Sum(i => i.Total);



            Console.WriteLine(new string('-', 65));
            Console.WriteLine($"Grand Total: {grandTotal:N2}");
            #endregion





            #region Save Bill to JSON
            BillSave billSave = new BillSave(bill.BillList, grandTotal);
            #endregion
        }
    }
}
