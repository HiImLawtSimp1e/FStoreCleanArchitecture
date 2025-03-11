namespace FStore.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.

            services.AddControllers();

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();


            return services;
        }

        public static WebApplication UseApiServices(this WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}
