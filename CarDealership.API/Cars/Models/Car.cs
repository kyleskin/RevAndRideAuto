namespace CarDealership.API.Cars.Models;

public record Car
{
    public int Id { get; init; }
    public string? Make { get; init; }
    public string? Model { get; init; }
    public int? Year { get; init; }
    public string? Vin { get; init; }
    public decimal? Price { get; init; }
    public CarStatus Status { get; init; }
    public DateTime CreatedDateTime { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedDateTime { get; init; } = DateTime.UtcNow;
}