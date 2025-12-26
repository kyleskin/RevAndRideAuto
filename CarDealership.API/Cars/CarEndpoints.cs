using CarDealership.API.Cars.Models;
using CarDealership.API.Cars.Services;

namespace CarDealership.API.Cars;

public static class CarEndpoints
{
    public static void MapCarEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/cars");

        group.MapGet("/", async (ICarService service) =>
            await service.GetAllCars());
        
        group.MapGet("/forsale", async (ICarService service) =>
            await service.GetAllForSaleCars());
        
        group.MapGet("/sold", async (ICarService service) =>
            await service.GetAllSoldCars());

        group.MapGet("/{id:int}", async (int id, ICarService service) => 
            await service.GetCarById(id) is { } car
                ? Results.Ok(car)
                : Results.NotFound());

        group.MapPost("/add", async (NewCar newCar, ICarService service) => 
            await service.AddNewCar(newCar) is { } insertedCar
                ? Results.Ok(insertedCar)
                : Results.InternalServerError());

        group.MapPut("/edit", async (EditCar editCar, ICarService service) =>
        {
            await service.EditCar(editCar);
            return Results.NoContent();
        });

        group.MapPatch("/{id:int}/available", async (int id, ICarService service) =>
        {
            await service.MakeCarAvailable(id);
            return Results.NoContent();
        });
        
        group.MapPatch("/{id:int}/testdrive", async (int id, ICarService service) =>
        {
            await service.TestDriveCar(id);
            return Results.NoContent();
        });
        
        group.MapPatch("/{id:int}/undercontract", async (int id, ICarService service) =>
        {
            await service.PutCarUnderContract(id);
            return Results.NoContent();
        });
    }
}