using CarDealership.API.Employees.Models;

namespace CarDealership.API.Employees.Services;

public interface IEmployeeService
{
    Task<List<EmployeeDto>> GetAllEmployees();
    Task<List<EmployeeDto>> GetCurrentEmployees();
    Task<EmployeeDto?> GetEmployeeById(int id);
    Task<EmployeeDto?> HireEmployee(HireEmployee hireEmployee);
    Task EditEmployee(EditEmployee editEmployee);
    Task TerminateEmployee(TerminateEmployee terminateEmployee);
}