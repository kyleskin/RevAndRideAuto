using CarDealership.API.Customers.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.API.Customers.DataAccess;

public class CustomerDataAccess
{
    private readonly AppDbContext _appDbContext;

    public CustomerDataAccess(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<Customer>> SelectAllCustomers() =>
        await _appDbContext.Customers.ToListAsync();

    public async Task<Customer?> SelectCustomerById(int id) =>
        await _appDbContext.Customers.FindAsync(id) ?? null;

    public async Task<Customer?> InsertCustomer(Customer customer)
    {
        await _appDbContext.Customers.AddAsync(customer);
        await _appDbContext.SaveChangesAsync();

        return customer;
    }

    public async Task UpdateCustomer(Customer updateCustomer)
    {
        var customer = await _appDbContext.Customers.FindAsync(updateCustomer.Id);

        if (customer is null)
        {
            throw new BadHttpRequestException("Cound not find customer to update");
        }

        var updatedCustomer = customer with
        {
            FirstName = updateCustomer.FirstName,
            LastName = updateCustomer.LastName,
            Email = updateCustomer.Email,
            Phone = updateCustomer.Phone,
            UpdatedDateTime = DateTime.UtcNow,
        };

        _appDbContext.Customers.Entry(customer).CurrentValues.SetValues(updatedCustomer);
        await _appDbContext.SaveChangesAsync();
    }
}