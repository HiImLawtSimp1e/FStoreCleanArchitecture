using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FStore.Application.Catalog.Services.Interfaces;
using FStore.Application.Catalog.Services.Implementations;

namespace FStore.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
