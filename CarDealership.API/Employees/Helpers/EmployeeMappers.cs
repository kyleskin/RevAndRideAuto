using CarDealership.API.Employees.Models;

namespace CarDealership.API.Employees.Helpers;

public static class EmployeeMappers
{
    public static EmployeeDto ToEmployeeDto(this Employee employee)
    {
        var jobTitle = employee.JobTitle ?? JobTitle.Invalid;
        
        return new()
        {
            EmployeeId = employee.Id,
            FirstName = employee.FirstName,
            MiddleInitial = employee.MiddleName?[..1],
            LastName = employee.LastName,
            Phone = employee.Phone,
            Email = employee.Email,
            JobTitle = JobTitleDisplay.GetJobTitleDisplayName(jobTitle),
            HireDate = employee.HireDate,
            TerminationDate = employee.TerminationDate,
        };
    }

    public static Employee ToEmployee(this HireEmployee employee) =>
        new()
        {
            FirstName = employee.FirstName,
            MiddleName = employee.MiddleName,
            LastName = employee.LastName,
            Phone = employee.Phone,
            Email = $"{employee.FirstName?.ToLower()}.{employee.LastName?.ToLower()}@revandrideauto.com",
            JobTitle = employee.JobTitle,
            HireDate = employee.HireDate,
        };

    public static Employee ToEmployee(this EditEmployee employee) =>
        new()
        {
            Id = employee.EmployeeId,
            FirstName = employee.FirstName,
            MiddleName = employee.MiddleName,
            LastName = employee.LastName,
            Phone = employee.Phone,
            JobTitle = employee.JobTitle,
        };
}