### OrderMapping

`OrderMapping` is a static mapping class responsible for converting an `Order` domain entity into an `OrderDto`.

#### Methods

* `ToDto(Order order)`: Converts an `Order` entity to an `OrderDto` including the order's customer information, calculated totals, and order items.

The customer's name is obtained from the related `Customer` entity:

`order.Customer?.Name`

The null-conditional operator allows `CustomerName` to be `null` if the related customer is not available.

The order's `Items` collection is converted into a list of `OrderItemDto` objects using LINQ `Select`.






### OrderItemMapping

`OrderItemMapping` is a static mapping class responsible for converting an `OrderItem` domain entity into an `OrderItemDto`.

#### Methods

* `ToDto(OrderItem orderItem)`: Converts an `OrderItem` to an `OrderItemDto`.

The mapping includes the order item's identifiers, quantity, price, and total.

The associated `Product` entity is not transferred directly. Instead, its `Name` is mapped to the `Product` property of the DTO.
