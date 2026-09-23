### OrderDto

`OrderDto` is a Data Transfer Object used to transfer order information without directly exposing the `Order` domain entity.

### Properties

* `Id`: Unique identifier of the order.
* `Items`: Collection of `OrderItemDto` objects representing the items included in the order. The collection is initialized as an empty list.
* `CustomerName`: Name of the customer associated with the order. This value can be `null`.
* `CustomerId`: Unique identifier of the customer associated with the order.
* `SubTotal`: Total price of all order items before tax.
* `Tax`: Tax amount calculated for the order.
* `Total`: Final order amount including tax.



### OrderItemDto

`OrderItemDto` is a Data Transfer Object used to transfer information about an item within an order without directly exposing the `OrderItem` domain entity.

### Properties

* `Id`: Unique identifier of the order item.
* `ProductId`: Unique identifier of the product associated with the order item.
* `Product`: Name or representation of the product associated with the order item. This value is required.
* `OrderId`: Unique identifier of the order containing the item.
* `Quantity`: Quantity of the product included in the order.
* `Price`: Price of the product for the order item.
* `Total`: Total price of the order item.
