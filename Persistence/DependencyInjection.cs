using JSFC.HeldenTaverne.Domain.Common.Persistence;
using JSFC.HeldenTaverne.Persistence.Implementations;
using JSFC.HeldenTaverne.Persistence.Implementations.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JSFC.HeldenTaverne.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySQL(
                "server=localhost;database=dsa5_character_manager;user=root;password=password",
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Transient);

        services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}