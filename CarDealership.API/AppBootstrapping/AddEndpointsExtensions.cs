using CarDealership.API.Cars;
using CarDealership.API.Customers;
using CarDealership.API.Employees;
using CarDealership.API.Sales;

namespace CarDealership.API.AppBootstrapping;

public static class AddEndpointsExtensions
{
    public static void MapEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapEmployeeEndpoints();
        routes.MapCarEndpoints();
        routes.MapCustomerEndpoints();
        routes.MapSaleEndpoints();
    }
}