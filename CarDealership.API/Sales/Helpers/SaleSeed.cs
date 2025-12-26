using CarDealership.API.Sales.Models;

namespace CarDealership.API.Sales.Helpers;

public static class SaleSeed
{
    public static List<Sale> GetSaleSeedData()
    {
        return new List<Sale>
        {
            new() { Id = 1, EmployeeId = 1, CustomerId = 4, CarId = 2, SoldDate = new DateOnly(2025, 06, 24) },
            new() { Id = 2, EmployeeId = 6, CustomerId = 3, CarId = 8, SoldDate = new DateOnly(2023, 01, 10) },
            new() { Id = 3, EmployeeId = 11, CustomerId = 8, CarId = 9, SoldDate = new DateOnly(2022, 01, 17) },
            new() { Id = 4, EmployeeId = 20, CustomerId = 1, CarId = 13, SoldDate = new DateOnly(2024, 05, 21) },
            new() { Id = 5, EmployeeId = 17, CustomerId = 10, CarId = 18, SoldDate = new DateOnly(2024, 05, 29) },
            new() { Id = 6, EmployeeId = 11, CustomerId = 12, CarId = 23, SoldDate = new DateOnly(2025, 08, 04) },
            new() { Id = 7, EmployeeId = 5, CustomerId = 13, CarId = 24, SoldDate = new DateOnly(2023, 11, 16) },
            new() { Id = 8, EmployeeId = 5, CustomerId = 8, CarId = 29, SoldDate = new DateOnly(2024, 09, 14) },
        };
    }
}