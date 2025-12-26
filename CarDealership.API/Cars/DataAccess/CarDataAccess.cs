using CarDealership.API.Cars.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.API.Cars.DataAccess;

public class CarDataAccess
{
    private readonly AppDbContext _appDbContext;

    public CarDataAccess(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<Car>> SelectAllCars() =>
        await _appDbContext.Cars.ToListAsync();

    public async Task<List<Car>> SelectForSaleCars() =>
        await _appDbContext.Cars.Where(c => c.Status != CarStatus.Sold).ToListAsync();

    public async Task<List<Car>> SelectSoldCars() =>
        await _appDbContext.Cars.Where(c => c.Status == CarStatus.Sold).ToListAsync();

    public async Task<Car?> SelectCarById(int id) =>
        await _appDbContext.Cars.FindAsync(id) ?? null;

    public async Task<Car?> InsertCar(Car car)
    {
        await _appDbContext.Cars.AddAsync(car);
        await _appDbContext.SaveChangesAsync();

        return car;
    }

    public async Task UpdateCar(Car updateCar)
    {
        var car = await _appDbContext.Cars.FindAsync(updateCar.Id);

        if (car is null)
        {
            throw new BadHttpRequestException("Could not find car to update");
        }

        var updatedCar = car with
        {
            Make = updateCar.Make,
            Model = updateCar.Model,
            Year = updateCar.Year,
            Vin = updateCar.Vin,
            Price = updateCar.Price,
            UpdatedDateTime = DateTime.UtcNow,
        };
        
        _appDbContext.Cars.Entry(car).CurrentValues.SetValues(updatedCar);
        await _appDbContext.SaveChangesAsync();
    }
    
    public async Task MakeCarAvailable(int id)
    {
        await UpdateCarStatus(id, CarStatus.Available);
    }

    public async Task TestDriveCar(int id)
    {
        await UpdateCarStatus(id, CarStatus.TestDrive);
    }
    
    public async Task PutCarUnderContract(int id)
    {
        await UpdateCarStatus(id, CarStatus.UnderContract);
    }

    private async Task UpdateCarStatus(int id, CarStatus status)
    {
        var car = await _appDbContext.Cars.FindAsync(id);
        
        if (car is null)
        {
            throw new BadHttpRequestException("Car not found");
        }

        var updatedCar = car with
        {
            Status = status,
            UpdatedDateTime = DateTime.UtcNow,
        };
        
        _appDbContext.Cars.Entry(car).CurrentValues.SetValues(updatedCar);
        await _appDbContext.SaveChangesAsync();
    }
}