namespace CarDealership.API.Customers.Models;

public record CustomerDto
{
    public required int CustomerId { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Phone { get; init; }
    public string? Email { get; init; }
}