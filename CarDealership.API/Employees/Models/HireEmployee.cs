namespace CarDealership.API.Employees.Models;

public record HireEmployee
{
    public string? FirstName { get; init; }
    public string? MiddleName { get; init; }
    public string? LastName { get; init; }
    public string? Phone { get; init; }
    public JobTitle? JobTitle { get; init; }
    public required DateOnly HireDate { get; init; }
}