### AdminMapping

`AdminMapping` is a static mapping class responsible for converting an `Admin` domain entity into an `AdminDto`.

#### Methods

* `ToDto(Admin admin)`: Converts an `Admin` entity to an `AdminDto` by mapping the `Id`, `Name`, `Email`, and `HasPermission` properties.




### CustomerMapping

`CustomerMapping` is a static mapping class responsible for converting a `Customer` domain entity into a `CustomerDto`.

#### Methods

* `ToDto(Customer customer)`: Converts a `Customer` entity to a `CustomerDto` by mapping the `Id`, `Name`, and `Phone` properties.
