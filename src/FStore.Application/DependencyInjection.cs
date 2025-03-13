using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FStore.Application.Catalog.Services.Interfaces;
using FStore.Application.Catalog.Services.Implementations;
using FStore.Application.UserIdentity.Services.Implementations;
using FStore.Application.UserIdentity.Services.Interfaces;

namespace FStore.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAccountService, AccountService>();

            return services;
        }
    }
}
