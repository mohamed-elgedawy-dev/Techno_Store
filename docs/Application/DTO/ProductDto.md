### ProductDto

`ProductDto` is a Data Transfer Object used to transfer product information without directly exposing the `Product` domain entity.

### Properties

* `Id`: Unique identifier of the product. The property uses `init`, so its value can only be assigned during object initialization.
* `Name`: Name of the product. This value is required.
* `Price`: Price of the product.
* `Stock`: Current quantity of the product available in stock.
