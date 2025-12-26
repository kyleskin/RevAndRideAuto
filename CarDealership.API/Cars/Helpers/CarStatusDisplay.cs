using CarDealership.API.Cars.Models;

namespace CarDealership.API.Cars.Helpers;

public static class CarStatusDisplay
{
    private static readonly Dictionary<CarStatus, string> _carStatusLookup = new()
    {
        { CarStatus.Invalid, "There was a problem getting the car status" },
        { CarStatus.Available, "Available and on the lot" },
        { CarStatus.TestDrive, "Out for a test drive" },
        { CarStatus.UnderContract, "Under contract" },
        { CarStatus.Sold, "Sold" },
    };

    public static string GetCarStatusDisplayName(CarStatus carStatus)
    {
        return _carStatusLookup[carStatus] ?? throw new ArgumentOutOfRangeException();
    } 
}