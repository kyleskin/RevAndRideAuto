using CarDealership.API.Cars.DataAccess;
using CarDealership.API.Cars.Helpers;
using CarDealership.API.Cars.Models;

namespace CarDealership.API.Cars.Services;

public class CarService : ICarService
{
    private readonly CarDataAccess _carDb;

    public CarService(CarDataAccess carDb)
    {
        _carDb = carDb;
    }

    public async Task<List<CarDto>> GetAllCars() =>
        (await _carDb.SelectAllCars())
        .Select(c => c.ToCarDto())
        .ToList();

    public async Task<List<CarDto>> GetAllForSaleCars() =>
        (await _carDb.SelectForSaleCars())
            .Select(c => c.ToCarDto())
            .ToList();

    public async Task<List<CarDto>> GetAllSoldCars() =>
        (await _carDb.SelectSoldCars())
            .Select(c => c.ToCarDto())
            .ToList();

    public async Task<CarDto?> GetCarById(int id)
    {
        var car = await _carDb.SelectCarById(id);

        return car?.ToCarDto();
    }
        

    public async Task<CarDto?> AddNewCar(NewCar newCar)
    {
        var car = newCar.ToCar();
        var addedCar = await _carDb.InsertCar(car);

        return addedCar?.ToCarDto();
    }

    public async Task EditCar(EditCar editCar)
    {
        var car = editCar.ToCar();
        await _carDb.UpdateCar(car);
    }

    public async Task MakeCarAvailable(int id)
    {
        await _carDb.MakeCarAvailable(id);
    }

    public async Task TestDriveCar(int id)
    {
        await _carDb.TestDriveCar(id);
    }

    public async Task PutCarUnderContract(int id)
    {
        await _carDb.PutCarUnderContract(id);
    }
}