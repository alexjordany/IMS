using IMS.Application.Contracts.Persistence;
using IMS.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IMS.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IMSDbContext>(options =>
        {
            options.UseInMemoryDatabase("IMS");
        });
        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

        services.AddScoped<IInventoryRepository, InventoryRepository>();

        return services;
    }
}
