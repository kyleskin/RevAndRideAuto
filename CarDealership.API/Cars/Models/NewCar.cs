namespace CarDealership.API.Cars.Models;

public record NewCar
{
    public string? Make { get; init; }
    public string? Model { get; init; }
    public int? Year { get; init; }
    public string? Vin { get; init; }
    public decimal? Price { get; init; }
}