using CarDealership.API.Sales.DataAccess;
using CarDealership.API.Sales.Helpers;
using CarDealership.API.Sales.Models;

namespace CarDealership.API.Sales.Services;

public class SaleService : ISaleService
{
    private readonly SaleDataAccess _saleDataAccess;

    public SaleService(SaleDataAccess saleDataAccess)
    {
        _saleDataAccess = saleDataAccess;
    }

    public async Task<List<SaleDto>> GetAllSales()
    {
        var sales = await _saleDataAccess.SelectAllSales();

        return sales.Select(s => s.ToSaleDto()).ToList();
    }

    public async Task<SaleDto?> GetSaleById(int id)
    {
        var sale = await _saleDataAccess.SelectSaleById(id);

        return sale?.ToSaleDto();
    }

    public async Task<List<SaleDto>?> GetSalesByEmployee(int employeeId)
    {
        var sales = await _saleDataAccess.SelectSalesByEmployee(employeeId);

        return sales.Select(s => s.ToSaleDto()).ToList();
    }

    public async Task<List<SaleDto>?> GetSalesByCustomer(int customerId)
    {
        var sales = await _saleDataAccess.SelectSalesByCustomer(customerId);

        return sales.Select(s => s.ToSaleDto()).ToList();
    }

    public async Task<SaleDto?> AddNewSale(NewSale newSale)
    {
        var sale = newSale.ToSale();
        var insertedSale = await _saleDataAccess.InsertNewSale(sale);

        return insertedSale.ToSaleDto();
    }

    public async Task EditSale(EditSale editSale)
    {
        var sale = editSale.ToSale();
        await _saleDataAccess.UpdateSale(sale);
    }
}