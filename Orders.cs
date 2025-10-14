using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class Orders
    {
       
   
        
        public event EventHandler? StockFinished;

        public void CheckStock( int productId, int? Amount, Data data)
        {
            int? currentStock = 0;

            for (int i = 0; i < data.Products.Count; i++)
            {
                if (productId == data.Products[i].Id)
                {

                    data.Products[i].Stock -= Amount;
                    currentStock = data.Products[i].Stock;


                }

            }


            if (currentStock <= 0)
            {
                OnStockFinished(EventArgs.Empty);
            }








        }


        protected virtual void OnStockFinished(EventArgs e)
        {
            StockFinished?.Invoke(this, e);
        }

        public  void Order_StockFinished(object? sender, EventArgs e)
        {
            Console.WriteLine("Stock finished for the selected product.");
        }



    }
}

