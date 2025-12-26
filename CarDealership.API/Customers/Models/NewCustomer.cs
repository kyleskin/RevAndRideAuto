namespace CarDealership.API.Customers.Models;

public record NewCustomer
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Phone { get; init; }
    public string? Email { get; init; }
}