using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FStore.Infrastructure.Persistence.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IHost app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<ApplicationDbContext>>();

            try
            {
                if (dbContext.Database.GetPendingMigrations().Any())
                {
                    logger.LogInformation("Applying database migrations...");
                    dbContext.Database.Migrate();
                    logger.LogInformation("Database migrations applied successfully.");
                }
                else
                {
                    logger.LogInformation("No pending migrations found.");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while applying database migrations.");
            }
        }
    }
}
