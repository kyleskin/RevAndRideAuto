namespace CarDealership.API.Employees.Models;

public record EditEmployee
{
    public required int EmployeeId { get; init; }
    public string? FirstName { get; init; }
    public string? MiddleName { get; init; }
    public string? LastName { get; init; }
    public string? Phone { get; init; }
    public JobTitle? JobTitle { get; init; }
}