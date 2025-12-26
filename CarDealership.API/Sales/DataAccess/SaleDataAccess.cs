using CarDealership.API.Sales.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.API.Sales.DataAccess;

public class SaleDataAccess
{
    private readonly AppDbContext _appDbContext;

    public SaleDataAccess(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<Sale>> SelectAllSales() =>
        await _appDbContext.Sales
            .Include(s => s.Employee)
            .Include(s => s.Customer)
            .Include(s => s.Car)
            .ToListAsync();

    public async Task<Sale?> SelectSaleById(int id) =>
        await _appDbContext.Sales
            .Where(s => s.Id == id)
            .Include(s => s.Employee)
            .Include(s => s.Customer)
            .Include(s => s.Car)
            .SingleOrDefaultAsync();

    public async Task<List<Sale>> SelectSalesByEmployee(int employeeId) =>
        await _appDbContext.Sales
            .Where(s => s.EmployeeId == employeeId)
            .Include(s => s.Employee)
            .Include(s => s.Customer)
            .Include(s => s.Car)
            .ToListAsync();

    public async Task<List<Sale>> SelectSalesByCustomer(int customerId) =>
        await _appDbContext.Sales
            .Where(s => s.CustomerId == customerId)
            .Include(s => s.Employee)
            .Include(s => s.Customer)
            .Include(s => s.Car)
            .ToListAsync();

    public async Task<Sale> InsertNewSale(Sale sale)
    {
        await _appDbContext.Sales.AddAsync(sale);
        await _appDbContext.SaveChangesAsync();

        return sale;
    }

    public async Task UpdateSale(Sale updateSale)
    {
        var sale = await _appDbContext.Sales.FindAsync(updateSale.Id);

        if (sale is null)
        {
            throw new BadHttpRequestException("Could not find sale to update");
        }

        var updatedSale = sale with
        {
            EmployeeId = updateSale.EmployeeId,
            CustomerId = updateSale.CustomerId,
            CarId = updateSale.CarId,
            SoldDate = updateSale.SoldDate,
            UpdatedDateTime = DateTime.UtcNow,
        };
        
        _appDbContext.Sales.Entry(sale).CurrentValues.SetValues(updatedSale);
        await _appDbContext.SaveChangesAsync();
    }
}