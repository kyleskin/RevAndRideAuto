namespace CarDealership.API.Sales.Models;

public record SaleDto
{
    public required int SaleId { get; init; }
    public required int EmployeeId { get; init; }
    public required int CustomerId { get; init; }
    public required int CarId { get; init; }
    public string? SalesPersonName { get; init; }
    public string? CustomerName { get; init; }
    public string? Car { get; init; }
    public decimal? SalesPrice { get; init; }
    public DateOnly SoldDate { get; init; }
}