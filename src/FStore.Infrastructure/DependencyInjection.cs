using FStore.Infrastructure.Mapping;
using FStore.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Add services to the container.
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            MapsterConfig.Configure();

            return services;
        }
    }
}