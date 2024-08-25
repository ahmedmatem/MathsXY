namespace MathsXY.WebAPI.Extensions
{
    using Microsoft.EntityFrameworkCore;

    using MathsXY.Infrastructure.Data;

    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Invalid connection string");
            services.AddDbContext<MathsXYContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
