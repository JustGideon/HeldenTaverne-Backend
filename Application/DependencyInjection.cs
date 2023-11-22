using JSFC.HeldenTaverne.Application.WeatherForecastService;
using Microsoft.Extensions.DependencyInjection;

namespace JSFC.HeldenTaverne.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IWeatherForecastService, WeatherForecastService.WeatherForecastService>();

        return services;
    }
}