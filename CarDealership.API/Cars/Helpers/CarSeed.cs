using CarDealership.API.Cars.Models;

namespace CarDealership.API.Cars.Helpers;

public static class CarSeed
{
    public static List<Car> GetCarSeedData()
    {
        return new List<Car>
        {
            new() { Id = 1, Make = "Toyota", Model = "Camry", Year = 2020, Vin = "JT123456789012345", Price = 24500.00m, Status = CarStatus.Available },
            new() { Id = 2, Make = "Honda", Model = "Accord", Year = 2019, Vin = "HG987654321098765", Price = 23000.00m, Status = CarStatus.Sold },
            new() { Id = 3, Make = "Ford", Model = "Mustang", Year = 2021, Vin = "FM456789012345678", Price = 36000.00m, Status = CarStatus.UnderContract },
            new() { Id = 4, Make = "Chevrolet", Model = "Malibu", Year = 2018, Vin = "CM234567890123456", Price = 21000.00m, Status = CarStatus.TestDrive },
            new() { Id = 5, Make = "Tesla", Model = "Model 3", Year = 2022, Vin = "TS345678901234567", Price = 42000.00m, Status = CarStatus.Available },
            new() { Id = 6, Make = "BMW", Model = "X5", Year = 2020, Vin = "BM567890123456789", Price = 58000.00m, Status = CarStatus.Available },
            new() { Id = 7, Make = "Audi", Model = "A4", Year = 2019, Vin = "AU678901234567890", Price = 37000.00m, Status = CarStatus.Available },
            new() { Id = 8, Make = "Mercedes-Benz", Model = "C-Class", Year = 2021, Vin = "MB789012345678901", Price = 45000.00m, Status = CarStatus.Sold },
            new() { Id = 9, Make = "Hyundai", Model = "Elantra", Year = 2018, Vin = "HY890123456789012", Price = 19000.00m, Status = CarStatus.Sold },
            new() { Id = 10, Make = "Kia", Model = "Sorento", Year = 2020, Vin = "KI901234567890123", Price = 28000.00m, Status = CarStatus.UnderContract },
            new() { Id = 11, Make = "Volkswagen", Model = "Passat", Year = 2019, Vin = "VW012345678901234", Price = 25000.00m, Status = CarStatus.TestDrive },
            new() { Id = 12, Make = "Subaru", Model = "Outback", Year = 2021, Vin = "SU123456789012345", Price = 32000.00m, Status = CarStatus.Available },
            new() { Id = 13, Make = "Mazda", Model = "CX-5", Year = 2020, Vin = "MZ234567890123456", Price = 29000.00m, Status = CarStatus.Sold },
            new() { Id = 14, Make = "Nissan", Model = "Altima", Year = 2018, Vin = "NS345678901234567", Price = 22000.00m, Status = CarStatus.Available },
            new() { Id = 15, Make = "Jeep", Model = "Wrangler", Year = 2022, Vin = "JP456789012345678", Price = 41000.00m, Status = CarStatus.Available },
            new() { Id = 16, Make = "Dodge", Model = "Charger", Year = 2021, Vin = "DG567890123456789", Price = 35000.00m, Status = CarStatus.UnderContract },
            new() { Id = 17, Make = "Ram", Model = "1500", Year = 2020, Vin = "RM678901234567890", Price = 45000.00m, Status = CarStatus.TestDrive },
            new() { Id = 18, Make = "Chevrolet", Model = "Silverado", Year = 2019, Vin = "CS789012345678901", Price = 43000.00m, Status = CarStatus.Sold },
            new() { Id = 19, Make = "GMC", Model = "Sierra", Year = 2021, Vin = "GC890123456789012", Price = 47000.00m, Status = CarStatus.Available },
            new() { Id = 20, Make = "Toyota", Model = "RAV4", Year = 2022, Vin = "TR901234567890123", Price = 31000.00m, Status = CarStatus.Available },
            new() { Id = 21, Make = "Honda", Model = "CR-V", Year = 2020, Vin = "HC012345678901234", Price = 30000.00m, Status = CarStatus.Available },
            new() { Id = 22, Make = "Ford", Model = "Explorer", Year = 2019, Vin = "FE123456789012345", Price = 34000.00m, Status = CarStatus.Available },
            new() { Id = 23, Make = "Tesla", Model = "Model Y", Year = 2021, Vin = "TY234567890123456", Price = 52000.00m, Status = CarStatus.Sold },
            new() { Id = 24, Make = "BMW", Model = "3 Series", Year = 2018, Vin = "B3S34567890123456", Price = 33000.00m, Status = CarStatus.Sold },
            new() { Id = 25, Make = "Audi", Model = "Q5", Year = 2020, Vin = "AQ567890123456789", Price = 48000.00m, Status = CarStatus.Available },
            new() { Id = 26, Make = "Mercedes-Benz", Model = "GLC", Year = 2019, Vin = "MG678901234567890", Price = 50000.00m, Status = CarStatus.Available },
            new() { Id = 27, Make = "Hyundai", Model = "Santa Fe", Year = 2021, Vin = "HS789012345678901", Price = 33000.00m, Status = CarStatus.Available },
            new() { Id = 28, Make = "Kia", Model = "Sportage", Year = 2018, Vin = "KS890123456789012", Price = 24000.00m, Status = CarStatus.Available },
            new() { Id = 29, Make = "Volkswagen", Model = "Jetta", Year = 2020, Vin = "VJ901234567890123", Price = 23000.00m, Status = CarStatus.Sold },
            new() { Id = 30, Make = "Subaru", Model = "Forester", Year = 2022, Vin = "SF012345678901234", Price = 34000.00m, Status = CarStatus.Available },
        };
    }
}