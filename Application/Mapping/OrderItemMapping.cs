using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techno_Store.Domain;
using Techno_Store.DTOs;

namespace Techno_Store.Application.Mapping
{
    public static class OrderItemMapping
    {


        public static OrderItemDto ToDto (OrderItem orderItem)
        {
            return new OrderItemDto
            {
                Id = orderItem.Id,
                ProductId = orderItem.ProductId,
                Product = orderItem.Product.Name,
                OrderId = orderItem.OrderId,
                Quantity = orderItem.Quantity,
                Total = orderItem.Total
            };
        }


    }
}
