using CarDealership.API.Employees.DataAccess;
using CarDealership.API.Employees.Helpers;
using CarDealership.API.Employees.Models;

namespace CarDealership.API.Employees.Services;

public class EmployeeService: IEmployeeService
{
    private readonly EmployeeDataAccess _employeeDb;

    public EmployeeService(EmployeeDataAccess employeeDb)
    {
        _employeeDb = employeeDb;
    }

    public async Task<List<EmployeeDto>> GetAllEmployees() =>
        (await _employeeDb.SelectAllEmployees())
        .Select(e => e.ToEmployeeDto())
        .ToList();

    public async Task<List<EmployeeDto>> GetCurrentEmployees() =>
        (await _employeeDb.SelectCurrentEmployees())
        .Select(e => e.ToEmployeeDto())
        .ToList();
    
    public async Task<EmployeeDto?> GetEmployeeById(int id)
    {
        var employee = await _employeeDb.SelectEmployeeById(id);

        return employee?.ToEmployeeDto();
    }

    public async Task<EmployeeDto?> HireEmployee(HireEmployee hireEmployee)
    {
        var employee = hireEmployee.ToEmployee();
        var createdEmployee = await _employeeDb.InsertEmployee(employee);

        return createdEmployee?.ToEmployeeDto();
    }

    public async Task EditEmployee(EditEmployee editEmployee)
    {
        var employee = editEmployee.ToEmployee();
        await _employeeDb.UpdateEmployee(employee);
    }

    public async Task TerminateEmployee(TerminateEmployee terminateEmployee)
    {
        await _employeeDb.TerminateEmployee(terminateEmployee);
    }
}