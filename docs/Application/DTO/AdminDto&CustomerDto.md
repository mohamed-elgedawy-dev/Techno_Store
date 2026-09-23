# Application

The Application layer contains Data Transfer Objects (DTOs) and mapping logic used to transfer data between different parts of the application.

## DTOs

### AdminDto

`AdminDto` is a Data Transfer Object used to transfer admin-related data without directly exposing the `Admin` domain entity.

#### Properties

* `Id`: Unique identifier of the admin.
* `Name`: Name of the admin.
* `Email`: Email address of the admin.
* `HasPermission`: Indicates whether the admin has permission to perform the relevant operation.

---

### CustomerDto

`CustomerDto` is a Data Transfer Object used to transfer customer-related data without directly exposing the `Customer` domain entity.

#### Properties

* `Id`: Unique identifier of the customer.
* `Name`: Name of the customer. This value can be `null`.
* `Phone`: Phone number of the customer. This value can be `null`.
