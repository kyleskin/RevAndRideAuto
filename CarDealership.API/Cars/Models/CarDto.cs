namespace CarDealership.API.Cars.Models;

public class CarDto
{
    public int CarId { get; init; }
    public string? Make { get; init; }
    public string? Model { get; init; }
    public int? Year { get; init; }
    public string? Vin { get; init; }
    public decimal? Price { get; init; }
    public string? Status { get; init; }
    public DateOnly? SoldDate { get; init; }
}