using CarDealership.API.Cars.DataAccess;
using CarDealership.API.Cars.Services;
using CarDealership.API.Customers.DataAccess;
using CarDealership.API.Customers.Services;
using CarDealership.API.Employees.DataAccess;
using CarDealership.API.Employees.Services;
using CarDealership.API.Sales.DataAccess;
using CarDealership.API.Sales.Services;

namespace CarDealership.API.AppBootstrapping;

public static class AddServicesExtensions
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<EmployeeDataAccess>();
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<CarDataAccess>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<CustomerDataAccess>();
        services.AddScoped<ISaleService, SaleService>();
        services.AddScoped<SaleDataAccess>();
    }
}