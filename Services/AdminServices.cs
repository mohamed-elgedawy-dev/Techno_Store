using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Techno_Store.Domain;

namespace Techno_Store.Services
{
    internal class AdminServices
    {



      

      

        public void UpdateProduct(Product product, string name, decimal price, int stock)
        {
            product.UpdateDetails(name, price, stock);
        }

        public void DeleteProduct(List<Product> products, int productId)
        {
            var productToDelete = products.FirstOrDefault(p => p.Id == productId);
            if (productToDelete != null)
                products.Remove(productToDelete);
        }


    }
}
