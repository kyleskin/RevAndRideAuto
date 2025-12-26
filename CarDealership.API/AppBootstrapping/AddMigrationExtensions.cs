using CarDealership.API.Cars.Helpers;
using CarDealership.API.Customers.Helpers;
using CarDealership.API.Employees.Helpers;
using CarDealership.API.Sales.Helpers;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.API.AppBootstrapping;

public static class AddMigrationExtensions
{
    public static void AddMigrationsAndSeedData(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        
        var appDbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        appDbContext.Database.Migrate();
        if (!appDbContext.Employees.Any())
        {
            appDbContext.Employees.AddRange(EmployeeSeed.GetEmployeeSeedData());
            appDbContext.SaveChanges();
        }
        
        if (!appDbContext.Cars.Any())
        {
            appDbContext.Cars.AddRange(CarSeed.GetCarSeedData());
            appDbContext.SaveChanges();
        }
        
        if (!appDbContext.Customers.Any())
        {
            appDbContext.Customers.AddRange(CustomerSeed.GetCustomerSeedData());
            appDbContext.SaveChanges();
        }

        if (!appDbContext.Sales.Any())
        {
            appDbContext.Sales.AddRange(SaleSeed.GetSaleSeedData());
            appDbContext.SaveChanges();
        }
    }
}