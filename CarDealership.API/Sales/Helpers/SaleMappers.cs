using CarDealership.API.Sales.Models;

namespace CarDealership.API.Sales.Helpers;

public static class SaleMappers
{
    public static SaleDto ToSaleDto(this Sale sale) =>
        new()
        {
            SaleId = sale.Id,
            EmployeeId = sale.EmployeeId,
            CustomerId = sale.CustomerId,
            CarId = sale.CarId,
            SalesPersonName = $"{sale.Employee.FirstName} {sale.Employee.LastName}",
            CustomerName = $"{sale.Customer.FirstName} {sale.Customer.LastName}",
            Car = $"{sale.Car.Year} {sale.Car.Make} {sale.Car.Model}",
            SalesPrice = sale.Car.Price,
            SoldDate = sale.SoldDate
        };

    public static Sale ToSale(this NewSale sale) =>
        new()
        {
            EmployeeId = sale.EmployeeId,
            CustomerId = sale.CustomerId,
            CarId = sale.CarId,
            SoldDate = sale.SoldDate,
        };
    
    public static Sale ToSale(this EditSale sale) =>
        new()
        {
            Id = sale.SalesId,
            EmployeeId = sale.EmployeeId,
            CustomerId = sale.CustomerId,
            CarId = sale.CarId,
            SoldDate = sale.SoldDate,
        };
}