using CarDealership.API.Cars.Models;

namespace CarDealership.API.Cars.Helpers;

public static class CarMappers
{
    public static CarDto ToCarDto(this Car car) =>
        new()
        {
            CarId = car.Id,
            Make = car.Make,
            Model = car.Model,
            Year = car.Year,
            Vin = car.Vin,
            Price = car.Price,
            Status = CarStatusDisplay.GetCarStatusDisplayName(car.Status),
        };

    public static Car ToCar(this NewCar car) =>
        new()
        {
            Make = car.Make,
            Model = car.Model,
            Year = car.Year,
            Vin = car.Vin,
            Price = car.Price,
            Status = CarStatus.Available,
        };

    public static Car ToCar(this EditCar car) =>
        new()
        {
            Id = car.CarId,
            Make = car.Make,
            Model = car.Model,
            Year = car.Year,
            Vin = car.Vin,
            Price = car.Price,
        };
}