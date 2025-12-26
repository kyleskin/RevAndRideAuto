namespace CarDealership.API.Sales.Models;

public record NewSale
{
    public required int EmployeeId { get; init; }
    public required int CustomerId { get; init; }
    public required int CarId { get; init; }
    public required DateOnly SoldDate { get; init; }
}