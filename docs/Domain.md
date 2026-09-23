application
   

   #domain

    ##base clase    [Represents the base class for all domain entities.]

       ### property

          - `Id`: Unique identifier for each entity.   
          


    ##admin        [ Represents the administrative domain of the application.]
     
           ### property
                   - `AdminId`: Unique identifier for each admin entity.   
                   - `Permissions`: List of permissions associated with the admin entity.

           ### Constructor
                 - Admin(string name, string email, bool hasPermission):
                   nitializes a new instance of the Admin class with the specified name, email, and permission status.



    ##Customer        [Represents the customer domain of the application.]


       ### property

          - `CustomerId`: Unique identifier for each customer entity.   
          - `Name`: Name of the customer.
          - 'phoneNumber': Contact phone number of the customer.


          ### Constructor

                - Customer(...): Initializes a new instance of the Customer class with the specified customer information.

          ### Methods
             - Update(...): Updates the customer's information with the provided values.




## Order     [Represents a customer's order and manages its order items and calculated totals.]

   ### Properties

     * `Items`: Read-only collection of the order items associated with the order.
     * `Customer`: The customer associated with the order.
     * `CustomerId`: Unique identifier of the customer associated with the order.
     * `SubTotal`: The total price of all order items before tax.
     * `Tax`: The tax amount calculated based on the order subtotal.
     * `Total`: The final order amount including tax.

### Constructor

     * `Order(Customer customer)`: Initializes a new order for the specified customer.

### Methods

    * `AddItem(Product product, int quantity)`: Creates and adds a new order item to the order, then recalculates the order totals.

    * `CalculateTotals()`: Calculates the subtotal, tax, and total amount of the order.


           
           ## OrderItem    [Represents an item within an order and maintains the relationship between an `Order` and a `Product`.]

### Properties

    * `ProductId`: Unique identifier of the product associated with the order item.
    * `Product`: The product associated with the order item.
    * `Price`: The current price of the associated product.
    * `OrderId`: Unique identifier of the order associated with the order item.
    * `Order`: The order that contains the order item.
    * `Quantity`: The quantity of the product included in the order item.
    * `Total`: The total price of the order item, calculated as the product price multiplied by the quantity.

### Constructors

    * `OrderItem(Product product, int quantity, Order order)`: Initializes a new order item with the specified product, quantity, and order.
    * `OrderItem()`: Private parameterless constructor used by Entity Framework Core when materializing the entity.



## Product     [Represents a product available in the store and manages its price and stock quantity.]



### Properties

    * `Name`: Name of the product.
    * `Price`: Price of the product.
    * `Stock`: Current quantity of the product available in stock.

### Constructor

    * `Product(string name, decimal price, int stock)`: Initializes a new instance of the `Product` class with the specified name, price, and stock quantity.

### Methods

    * `IsInStock(int quantity)`: Determines whether the requested quantity is available in stock.

    * `UpdateStock(int quantity)`: Updates the current stock quantity of the product.

    * `UpdateDetails(string name, decimal price, int stock)`: Updates the product's name, price, and stock quantity.

    * `ReduceStock(int quantity)`: Reduces the product's stock by the specified quantity if the requested quantity is available.


    Order contains multiple OrderItem.
    OrderItem references one Product.
    Order belongs to one Customer.
    Order calculates SubTotal, Tax, and Total.
    Product controls stock through domain methods.