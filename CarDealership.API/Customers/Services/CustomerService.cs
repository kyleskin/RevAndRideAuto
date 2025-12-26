using CarDealership.API.Customers.DataAccess;
using CarDealership.API.Customers.Helpers;
using CarDealership.API.Customers.Models;

namespace CarDealership.API.Customers.Services;

public class CustomerService : ICustomerService
{
    private readonly CustomerDataAccess _customerDb;

    public CustomerService(CustomerDataAccess customerDb)
    {
        _customerDb = customerDb;
    }

    public async Task<List<CustomerDto>> GetAllCustomers() =>
        (await _customerDb.SelectAllCustomers())
        .Select(c => c.ToCustomerDto())
        .ToList();

    public async Task<CustomerDto?> GetCustomerById(int id)
    {
        var customer = await _customerDb.SelectCustomerById(id);

        return customer?.ToCustomerDto();
    }

    public async Task<CustomerDto?> AddNewCustomer(NewCustomer newCustomer)
    {
        var customer = newCustomer.ToCustomer();
        var createdCustomer = await _customerDb.InsertCustomer(customer);

        return createdCustomer?.ToCustomerDto();
    }

    public async Task EditCustomer(EditCustomer editCustomer)
    {
        var customer = editCustomer.ToCustomer();
        await _customerDb.UpdateCustomer(customer);
    }
}