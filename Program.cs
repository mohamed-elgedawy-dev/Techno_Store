namespace Techno_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialization

            Orders order = new Orders();
            View view = new View();

            Bill bill = new Bill();
            Data data = new Data();
            Display display = new Display();

            bool continueOrdering = true;
            #endregion

            display.CustomerName = view.TakingName();
            do
            {
                display.DisplayData(data);

                order.StockFinished += order.Order_StockFinished;

                var selectedId = view.TakingId(data);
                if (selectedId != null)
                {
                    view.TakingAmount();
                }
                else
                {
                    Console.WriteLine("No product selected. Returning to menu.");
                }

                if (view.ItemAmount == null || view.ItemAmount <= 0)
                {
                    Console.WriteLine("Invalid amount entered. Please try again.");
                    continue;
                }
                else
                {
                    order.CheckStock(view.Product.Id, view.ItemAmount, data);
                }

                bill.BillList.Add(
                    new BillItem
                    {
                        ProductName = view.Product.Name,
                        Amount = view.ItemAmount,
                        Price = view.Price,

                        Total = view.Price * view.ItemAmount,
                    }
                );

                data.SaveChanges(data);

                continueOrdering = view.AskToContinueOrFinish();
            } while (continueOrdering);

            #region Save Bill to JSON
            BillSave billSave = new BillSave(
                bill.BillList,
                display.CustomerName,
                display.ShowBill(bill)
            );
            #endregion
        }
    }
}
