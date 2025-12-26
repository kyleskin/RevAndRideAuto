using CarDealership.API.Sales.Models;

namespace CarDealership.API.Sales.Services;

public interface ISaleService
{
    Task<List<SaleDto>> GetAllSales();
    Task<SaleDto?> GetSaleById(int id);
    Task<List<SaleDto>?> GetSalesByEmployee(int employeeId);
    Task<List<SaleDto>?> GetSalesByCustomer(int customerId);
    Task<SaleDto?> AddNewSale(NewSale newSale);
    Task EditSale(EditSale editSale);
}