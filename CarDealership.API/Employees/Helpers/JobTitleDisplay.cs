using CarDealership.API.Employees.Models;

namespace CarDealership.API.Employees.Helpers;

public static class JobTitleDisplay
{
    private static readonly Dictionary<JobTitle, string> _jobTitleLookup = new()
    {
        { JobTitle.Invalid, "There was a problem getting the job title" },
        { JobTitle.SalesRepresentative, "Sales Representative" },
        { JobTitle.AssistantSalesManager, "Assistant Sales Manager" },
        { JobTitle.SalesManager, "Sales Manager" },
        { JobTitle.AssistantToTheRegionalManager, "Assistant to the Regional Manager" },
        { JobTitle.RegionalManager, "Regional Manager" },
        { JobTitle.Mechanic, "Mechanic" },
        { JobTitle.ShopManager, "Shop Manager" },
    };

    public static string GetJobTitleDisplayName(JobTitle jobTitle)
    {
        return _jobTitleLookup[jobTitle] ?? throw new ArgumentOutOfRangeException();
    }
}