using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Techno_Store.Data;

namespace Techno_Store
{
    internal class Orders
    {
        public event EventHandler? StockFinished;

        public void CheckStock(int productId, int? Amount, DataServices data)
        {
            int? currentStock = 0;
            var products = data.GetAllProduct();
            for (int i = 0; i < products.Count; i++)
            {
                if (productId == products[i].Id)
                {
                    data.GetAllProduct()[i].Stock -= Amount;
                    currentStock = products[i].Stock;
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

        public void Order_StockFinished(object? sender, EventArgs e)
        {
            Console.WriteLine("Stock finished for the selected product.");
        }
    }
}
