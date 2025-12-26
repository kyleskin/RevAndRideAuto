using CarDealership.API.Customers.Models;

namespace CarDealership.API.Customers.Helpers;

public static class CustomerMappers
{
    public static CustomerDto ToCustomerDto(this Customer customer) =>
        new CustomerDto
        {
            CustomerId = customer.Id,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Email = customer.Email,
            Phone = customer.Phone,
        };

    public static Customer ToCustomer(this NewCustomer customer) =>
        new Customer
        {
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Email = customer.Email,
            Phone = customer.Phone,
        };
    
    public static Customer ToCustomer(this EditCustomer customer) =>
        new Customer
        {
            Id = customer.CustomerId,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Email = customer.Email,
            Phone = customer.Phone,
        };
}