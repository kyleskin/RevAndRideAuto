namespace CarDealership.API.Customers.Models;

public record Customer
{
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Phone { get; init; }
    public string? Email { get; init; }
    public DateTime CreatedDateTime { get; init; }
    public DateTime UpdatedDateTime { get; init; }
}
