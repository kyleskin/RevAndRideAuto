using Microsoft.EntityFrameworkCore;

namespace CarDealership.API.AppBootstrapping;

public static class AddDbContextsExtensions
{
    public static void AddDbContexts(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
    }
}