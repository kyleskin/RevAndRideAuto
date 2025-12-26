using CarDealership.API.Customers.Models;
using CarDealership.API.Customers.Services;

namespace CarDealership.API.Customers;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/customers");

        group.MapGet("/", async (ICustomerService service) =>
            await service.GetAllCustomers());

        group.MapGet("/{id:int}", async (int id, ICustomerService service) =>
            await service.GetCustomerById(id) is { } customer
                ? Results.Ok(customer)
                : Results.NotFound());

        group.MapPost("/add", async (NewCustomer newCustomer, ICustomerService service) =>
            await service.AddNewCustomer(newCustomer) is { } insertedCustomer
                ? Results.Created($"customers/{insertedCustomer.CustomerId}", insertedCustomer)
                : Results.InternalServerError());

        group.MapPut("/edit", async (EditCustomer editCustomer, ICustomerService service) =>
        {
            await service.EditCustomer(editCustomer);
            return Results.NoContent();
        });
    }
}