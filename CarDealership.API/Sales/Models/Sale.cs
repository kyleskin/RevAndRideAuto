using CarDealership.API.Cars.Models;
using CarDealership.API.Customers.Models;
using CarDealership.API.Employees.Models;

namespace CarDealership.API.Sales.Models;

public record Sale
{
    public int Id { get; init; }
    public int EmployeeId { get; init; }
    public Employee Employee { get; set; } = null!;
    public int CustomerId { get; init; }
    public Customer Customer { get; set; } = null!;
    public int CarId { get; init; }
    public Car Car { get; set; } = null!;
    public required DateOnly SoldDate { get; init; }
    public DateTime CreatedDateTime { get; init; }
    public DateTime UpdatedDateTime { get; init; }
}