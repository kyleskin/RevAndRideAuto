using CarDealership.API.Employees.Models;
using CarDealership.API.Employees.Services;

namespace CarDealership.API.Employees;

public static class EmployeeEndpoints
{
    public static void MapEmployeeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/employees");
        
        group.MapGet("/", async (IEmployeeService service) =>
            await service.GetAllEmployees());

        group.MapGet("/current", async (IEmployeeService service) =>
            await service.GetCurrentEmployees());

        group.MapGet("/{id:int}", async (int id, IEmployeeService service) =>
            await service.GetEmployeeById(id) is { } employee
                ? Results.Ok(employee)
                : Results.NotFound());

        group.MapPost("/hire", async (HireEmployee employee, IEmployeeService service) =>
            await service.HireEmployee(employee) is { } insertedEmployee
                ? Results.Created($"employees/{insertedEmployee.EmployeeId}", insertedEmployee)
                : Results.InternalServerError());

        group.MapPut("/edit", async (EditEmployee employee, IEmployeeService service) =>
        {
            await service.EditEmployee(employee);
            return Results.NoContent();
        });

        group.MapPost("/terminate", async (TerminateEmployee employee, IEmployeeService service) =>
        {
            await service.TerminateEmployee(employee);
            return Results.NoContent();
        });
    }
}