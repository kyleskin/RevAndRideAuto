using CarDealership.API.Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.API.Employees.DataAccess;

public class EmployeeDataAccess
{
    private readonly AppDbContext _appDbContext;

    public EmployeeDataAccess(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<Employee>> SelectAllEmployees() => 
        await _appDbContext.Employees.ToListAsync();

    public async Task<List<Employee>> SelectCurrentEmployees() =>
        await _appDbContext.Employees.Where(e => e.TerminationDate == null
                                                 || e.TerminationDate > DateOnly.FromDateTime(DateTime.UtcNow))
            .ToListAsync();

    public async Task<Employee?> SelectEmployeeById(int id) =>
        await _appDbContext.Employees.FindAsync(id) ?? null;

    public async Task<Employee?> InsertEmployee(Employee employee)
    {
        await _appDbContext.Employees.AddAsync(employee);
        await _appDbContext.SaveChangesAsync();

        return employee;
    }

    public async Task UpdateEmployee(Employee updateEmployee)
    {
        var employee = await _appDbContext.Employees.FindAsync(updateEmployee.Id);
        
        if (employee is null)
        {
            throw new BadHttpRequestException("Could not find employee to update");
        }

        var updatedEmployee = employee with
        {
            FirstName = updateEmployee.FirstName,
            MiddleName = updateEmployee.MiddleName,
            LastName = updateEmployee.LastName,
            Phone = updateEmployee.Phone,
            JobTitle = updateEmployee.JobTitle,
            UpdatedDateTime = DateTime.UtcNow,
        };

        _appDbContext.Employees.Entry(employee).CurrentValues.SetValues(updatedEmployee);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task TerminateEmployee(TerminateEmployee terminateEmployee)
    {
        var employee = await _appDbContext.Employees.FindAsync(terminateEmployee.EmployeeId);

        if (employee is null)
        {
            throw new BadHttpRequestException("Could not find employee to terminate");
        }

        var updatedEmployee = employee with
        {
            TerminationDate = terminateEmployee.TerminationDate,
            UpdatedDateTime = DateTime.UtcNow,
        };

        _appDbContext.Employees.Entry(employee).CurrentValues.SetValues(updatedEmployee);
        await _appDbContext.SaveChangesAsync();
    }
}