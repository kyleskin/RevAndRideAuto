using CarDealership.API.Customers.Models;

namespace CarDealership.API.Customers.Services;

public interface ICustomerService
{
    Task<List<CustomerDto>> GetAllCustomers();
    Task<CustomerDto?> GetCustomerById(int id);
    Task<CustomerDto?> AddNewCustomer(NewCustomer customer);
    Task EditCustomer(EditCustomer editCustomer);
}