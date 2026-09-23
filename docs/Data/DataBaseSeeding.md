## DataBaseSeeding

`DataBaseSeeding` is responsible for retrieving product data from an external API and converting it into `Product` domain entities.

### GetProductsAsync

`GetProductsAsync()` asynchronously retrieves products from the Fake Store API.

The process is:

1. Sends an HTTP GET request to the external API.
2. Deserializes the JSON response into `ApiProduct` objects.
3. Converts each `ApiProduct` into a `Product` domain entity.
4. Sets the initial stock of each product to `50`.
5. Returns the resulting `List<Product>`.

If the API response cannot be deserialized into a list, an empty list is returned.

### ApiProduct

`ApiProduct` is a private class used to represent the product structure returned by the external API.

Properties:

* `Id`: External API product identifier.
* `Title`: Product title.
* `Price`: Product price.

The external API model is kept separate from the domain `Product` entity and is converted before being returned.
