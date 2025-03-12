using FStore.Infrastructure.Mapping;
using FStore.Infrastructure.Persistence.Interceptors;
using FStore.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
            services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>(); // Register Audit Interceptor

            services.AddDbContext<ApplicationDbContext>((sp, options) =>
            {
                options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
                options.UseSqlServer(connectionString);
            }); // Register EF ORM DbContext

            services.AddScoped<IUnitOfWork, UnitOfWork>(); // Register Repository Unit of Work

            MapsterConfig.Configure(); // Configuring Mapster

            return services;
        }
    }
}