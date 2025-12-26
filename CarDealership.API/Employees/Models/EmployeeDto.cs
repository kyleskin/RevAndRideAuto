namespace CarDealership.API.Employees.Models;

public record EmployeeDto
{
    public required int EmployeeId { get; init; }
    public string? FirstName { get; init; }
    public string? MiddleInitial { get; init; }
    public string? LastName { get; init; }
    public string? Phone { get; init; }
    public string? Email { get; init; }
    public string? JobTitle { get; init; }
    public DateOnly? HireDate { get; init; }
    public DateOnly? TerminationDate { get; init; } = null;
}