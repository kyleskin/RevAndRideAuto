using CarDealership.API.Sales.Models;
using CarDealership.API.Sales.Services;

namespace CarDealership.API.Sales;

public static class SaleEndpoints
{
    public static void MapSaleEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/sales");

        group.MapGet("/", async (ISaleService service) =>
            await service.GetAllSales());

        group.MapGet("/{id:int}", async (int id, ISaleService service) =>
            await service.GetSaleById(id) is { } sale
                ? Results.Ok(sale)
                : Results.NotFound());
        
        group.MapGet("/byemployee", async (int employeeId, ISaleService service) =>
            await service.GetSalesByEmployee(employeeId));
        
        group.MapGet("/bycustomer", async (int customerId, ISaleService service) =>
            await service.GetSalesByCustomer(customerId));
        
        group.MapPost("/newsale", async (NewSale newSale, ISaleService service) =>
            await service.AddNewSale(newSale) is { } insertedSale
                ? Results.Created($"sales/{insertedSale.SaleId}", insertedSale)
                : Results.InternalServerError());

        group.MapPut("/edit", async (EditSale editSale, ISaleService service) =>
        {
            await service.EditSale(editSale);
            return Results.NoContent();
        });
    }
}