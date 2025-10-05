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
        public Data data { get; set; } = new Data();
   
        


        public void MakingOrder( int productId, int Amount)
        {
            
            for (int i = 0; i < data.Products.Count; i++)
            {
                if (productId == data.Products[i].Id)
                {

                    data.Products[i].Stock -= Amount;


                }


            }



        }

        public void SaveChanges()
        {
            string updatedJson = JsonSerializer.Serialize(data.Products);
            File.WriteAllText(data.filePath, updatedJson);
        }

    }
}
// Added for full review PR
