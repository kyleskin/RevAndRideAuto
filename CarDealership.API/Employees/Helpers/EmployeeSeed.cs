using CarDealership.API.Employees.Models;

namespace CarDealership.API.Employees.Helpers;

public static class EmployeeSeed
{
    public static List<Employee> GetEmployeeSeedData()
    {
        return new List<Employee>
        {
            new()
            {
                Id = 1,
                FirstName = "Ethan",
                MiddleName = "James",
                LastName = "Carter",
                Phone = "385-555-1023",
                Email = "ethan.carter@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2025, 07, 11),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 2,
                FirstName = "Sophia",
                MiddleName = "Marie",
                LastName = "Bennett",
                Phone = "385-555-1047",
                Email = "sophia.bennett@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2023, 11, 02),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 3,
                FirstName = "Lucas",
                MiddleName = "Alexander",
                LastName = "Hayes",
                Phone = "385-555-1098",
                Email = "lucas.hayes@revandrideauto.com",
                JobTitle = JobTitle.SalesManager,
                HireDate = new DateOnly(2022, 08, 19),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 4,
                FirstName = "Isabella",
                MiddleName = "Rose",
                LastName = "Mitchell",
                Phone = "385-555-1189",
                Email = "isabella.mitchell@revandrideauto.com",
                JobTitle = JobTitle.Mechanic,
                HireDate = new DateOnly(2024, 06, 05),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 5,
                FirstName = "Caleb",
                MiddleName = "Ryan",
                LastName = "Foster",
                Phone = "385-555-1213",
                Email = "caleb.foster@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2022, 12, 12),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 6,
                FirstName = "Olivia",
                MiddleName = "Grace",
                LastName = "Thompson",
                Phone = "385-555-1124",
                Email = "olivia.thompson@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2025, 09, 28),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 7,
                FirstName = "Nathaniel",
                MiddleName = "Cole",
                LastName = "Anderson",
                Phone = "385-555-1156",
                Email = "nathaniel.anderson@revandrideauto.com",
                JobTitle = JobTitle.ShopManager,
                HireDate = new DateOnly(2021, 01, 15),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 8,
                FirstName = "Madeline",
                MiddleName = "Claire",
                LastName = "Brooks",
                Phone = "385-555-1245",
                Email = "madeline.brooks@revandrideauto.com",
                JobTitle = JobTitle.AssistantSalesManager,
                HireDate = new DateOnly(2025, 07, 11),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 9,
                FirstName = "Dylan",
                MiddleName = "Matthew",
                LastName = "Parker",
                Phone = "385-555-1278",
                Email = "dylan.parker@revandrideauto.com",
                JobTitle = JobTitle.Mechanic,
                HireDate = new DateOnly(2023, 04, 27),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 10,
                FirstName = "Charlotte",
                MiddleName = "Elise",
                LastName = "Morgan",
                Phone = "385-555-1302",
                Email = "charlotte.morgan@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2025, 07, 11),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 11,
                FirstName = "Benjamin",
                MiddleName = "Scott",
                LastName = "Reed",
                Phone = "385-555-1336",
                Email = "benjamin.reed@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2022, 03, 08),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 12,
                FirstName = "Amelia",
                MiddleName = "Jane",
                LastName = "Sullivan",
                Phone = "385-555-1369",
                Email = "amelia.sullivan@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2025, 08, 21),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 13,
                FirstName = "Gabriel",
                MiddleName = "Thomas",
                LastName = "Hughes",
                Phone = "385-555-1394",
                Email = "gabriel.hughes@revandrideauto.com",
                JobTitle = JobTitle.Mechanic,
                HireDate = new DateOnly(2024, 01, 29),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 14,
                FirstName = "Victoria",
                MiddleName = "Anne",
                LastName = "Collins",
                Phone = "385-555-1428",
                Email = "victoria.collins@revandrideauto.com",
                JobTitle = JobTitle.Mechanic,
                HireDate = new DateOnly(2023, 06, 17),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 15,
                FirstName = "Samuel",
                MiddleName = "Dean",
                LastName = "Harrison",
                Phone = "385-555-1453",
                Email = " samuel.harrison@revandrideauto.com",
                JobTitle = JobTitle.AssistantSalesManager,
                HireDate = new DateOnly(2021, 12, 01),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 16,
                FirstName = "Emily",
                MiddleName = "Kate",
                LastName = "Dawson",
                Phone = "385-555-1487",
                Email = "emily.dawson@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2025, 11, 15),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 17,
                FirstName = "Julian",
                MiddleName = "Michael",
                LastName = "Turner",
                Phone = "385-555-1512",
                Email = "julian.turner@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2023, 07, 05),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 18,
                FirstName = "Hannah",
                MiddleName = "Louise",
                LastName = "Bryant",
                Phone = "385-555-1546",
                Email = "hannah.bryant@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2024, 09, 09),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 19,
                FirstName = "Christopher",
                MiddleName = "Owen",
                LastName = "Wallace",
                Phone = "385-555-1579",
                Email = "christopher.wallace@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2023, 02, 10),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            },
            new()
            {
                Id = 20,
                FirstName = "Abigail",
                MiddleName = "Faith",
                LastName = "Reynolds",
                Phone = "385-555-1603",
                Email = "abigail.reynolds@revandrideauto.com",
                JobTitle = JobTitle.SalesRepresentative,
                HireDate = new DateOnly(2025, 06, 26),
                CreatedDateTime = DateTime.UtcNow,
                UpdatedDateTime = DateTime.UtcNow,
            }
        };
    }
}