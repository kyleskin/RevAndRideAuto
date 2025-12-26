namespace CarDealership.API.Employees.Models;

public record TerminateEmployee
{
    public required int EmployeeId { get; init; }
    public required DateOnly TerminationDate { get; init; }
}