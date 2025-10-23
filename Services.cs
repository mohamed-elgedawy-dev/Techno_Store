using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Data;
using Techno_Store.Entity;

namespace Techno_Store
{
    internal class Services
    {
        #region Initialization

        Orders order = new Orders();
        View view = new View();

        Bill bill = new Bill();
        DataServices data = new DataServices();

        Display display = new Display();

        bool continueOrdering = true;
        #endregion


        public void AddBillItems()
        {
            bill.BillList.Add(
                new BillItem
                {
                    ProductName = view.Product.Name,
                    Amount = view.ItemAmount,
                    Price = view.Price,

                    Total = view.Price * view.ItemAmount,
                }
            );
        }

        public List<BillItem> start()
        {
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

                AddBillItems();

                data.SaveChanges();

                continueOrdering = view.AskToContinueOrFinish();
            } while (continueOrdering);

            return bill.BillList;
        }
    }
}
