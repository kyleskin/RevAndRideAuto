using CarDealership.API.Customers.Models;

namespace CarDealership.API.Customers.Helpers;

public static class CustomerSeed
{
    public static List<Customer> GetCustomerSeedData()
    {
        return new List<Customer>
        {
            new() { Id = 1, FirstName = "Alice", LastName = "Johnson", Phone = "(555) 321-9876", Email = "alice.johnson@example.com" },
            new() { Id = 2, FirstName = "Bob", LastName = "Smith", Phone = "(555) 654-1234", Email = "bob.smith@example.com" },
            new() { Id = 3, FirstName = "Carol", LastName = "Anderson", Phone = "(555) 789-4561", Email = "carol.anderson@example.com" },
            new() { Id = 4, FirstName = "David", LastName = "Brown", Phone = "(555) 234-5678", Email = "david.brown@example.com" },
            new() { Id = 5, FirstName = "Emma", LastName = "Davis", Phone = "(555) 876-5432", Email = "emma.davis@example.com" },
            new() { Id = 6, FirstName = "Frank", LastName = "Wilson", Phone = "(555) 432-6789", Email = "frank.wilson@example.com" },
            new() { Id = 7, FirstName = "Grace", LastName = "Taylor", Phone = "(555) 567-8901", Email = "grace.taylor@example.com" },
            new() { Id = 8, FirstName = "Henry", LastName = "Moore", Phone = "(555) 345-6789", Email = "henry.moore@example.com" },
            new() { Id = 9, FirstName = "Isabella", LastName = "Clark", Phone = "(555) 678-1234", Email = "isabella.clark@example.com" },
            new() { Id = 10, FirstName = "Jack", LastName = "Hall", Phone = "(555) 901-2345", Email = "jack.hall@example.com" },
            new() { Id = 11, FirstName = "Karen", LastName = "Allen", Phone = "(555) 213-4567", Email = "karen.allen@example.com" },
            new() { Id = 12, FirstName = "Liam", LastName = "Young", Phone = "(555) 789-0123", Email = "liam.young@example.com" },
            new() { Id = 13, FirstName = "Mia", LastName = "King", Phone = "(555) 890-1234", Email = "mia.king@example.com" },
            new() { Id = 14, FirstName = "Noah", LastName = "Wright", Phone = "(555) 456-7890", Email = "noah.wright@example.com" },
            new() { Id = 15, FirstName = "Sophia", LastName = "Bennett", Phone = "(555) 678-9012", Email = "sophia.bennett@example.com" },
        };
    }
}