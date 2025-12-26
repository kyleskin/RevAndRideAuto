using CarDealership.API.Cars.Models;

namespace CarDealership.API.Cars.Services;

public interface ICarService
{
    Task<List<CarDto>> GetAllCars();
    Task<List<CarDto>> GetAllForSaleCars();
    Task<List<CarDto>> GetAllSoldCars();
    Task<CarDto?> GetCarById(int id);
    Task<CarDto?> AddNewCar(NewCar car);
    Task EditCar(EditCar editCar);
    Task MakeCarAvailable(int id);
    Task TestDriveCar(int id);
    Task PutCarUnderContract(int id);
}