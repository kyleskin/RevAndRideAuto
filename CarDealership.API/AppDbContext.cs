using CarDealership.API.Cars.Models;
using CarDealership.API.Customers.Models;
using CarDealership.API.Employees.Models;
using CarDealership.API.Sales.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.API;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<Sale> Sales => Set<Sale>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var employee = modelBuilder.Entity<Employee>().ToTable("Employees");
        employee.HasKey(e => e.Id);
        employee.Property(e => e.CreatedDateTime)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        employee.Property(e => e.UpdatedDateTime)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        
        var customer = modelBuilder.Entity<Customer>().ToTable("Customers");
        customer.HasKey(c => c.Id);
        customer.Property(c => c.CreatedDateTime)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        customer.Property(c => c.UpdatedDateTime)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        
        var car = modelBuilder.Entity<Car>().ToTable("Cars");
        car.HasKey(c => c.Id);
        car.Property(c => c.CreatedDateTime)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        car.Property(c => c.UpdatedDateTime)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        
        var sale = modelBuilder.Entity<Sale>().ToTable("Sales");
        sale.HasKey(s => s.Id);
        sale.Property(s => s.CreatedDateTime)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        sale.Property(s => s.UpdatedDateTime)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        sale.HasOne(s => s.Employee)
            .WithMany()
            .HasForeignKey(s => s.EmployeeId);
        sale.HasOne(s => s.Customer)
            .WithMany()
            .HasForeignKey(s => s.CustomerId);
        sale.HasOne(s => s.Car)
            .WithMany()
            .HasForeignKey(s => s.CarId);
    }
}