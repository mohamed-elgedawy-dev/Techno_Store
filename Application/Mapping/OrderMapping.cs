using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Domain;
using Techno_Store.DTOs;

namespace Techno_Store.Application.Mapping
{
    public static class OrderMapping
    {




        public static OrderDto ToDto (Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                CustomerName = order.Customer?.Name,
                SubTotal = order.SubTotal,
                Tax = order.Tax,
                Total = order.Total,
                Items = order.Items.Select(oi => new OrderItemDto
                {
                    Id = oi.Id,
                    ProductId = oi.ProductId,
                    Product = oi.Product.Name,
                    OrderId = oi.OrderId,
                    Quantity = oi.Quantity,
                    Total = oi.Total


                }).ToList()

            };
        }

      
    }
}
