namespace CarDealership.API.Employees.Models;

public record Employee
{
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? MiddleName { get; init; }
    public string? LastName { get; init; }
    public string? Phone { get; init; }
    public string? Email { get; init; }
    public JobTitle? JobTitle { get; init; }
    public DateOnly? HireDate { get; init; }
    public DateOnly? TerminationDate { get; init; }
    public DateTime CreatedDateTime { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedDateTime { get; init; } = DateTime.UtcNow;
}