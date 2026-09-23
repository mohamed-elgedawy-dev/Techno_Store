# Data

## AppDbContext

`AppDbContext` is the Entity Framework Core database context used to interact with the SQL Server database.

### Inheritance

* Inherits from `DbContext`.

### DbSets

The context exposes the following entities as `DbSet` properties:

* `Products`: Represents the `Product` entities in the database.
* `Orders`: Represents the `Order` entities.
* `OrderItems`: Represents the `OrderItem` entities.
* `Customers`: Represents the `Customer` entities.
* `Admins`: Represents the `Admin` entities.

### Constructors

* `AppDbContext(DbContextOptions<AppDbContext> options)`: Initializes the context using the provided EF Core options.
* `AppDbContext()`: Parameterless constructor.

### OnConfiguring

`OnConfiguring()` configures the database connection when the context is not already configured.

It:

1. Builds a configuration from `appsettings.json`.
2. Reads the `DefaultConnection` connection string.
3. Configures EF Core to use SQL Server.
