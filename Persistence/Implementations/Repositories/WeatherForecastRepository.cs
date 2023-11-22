namespace JSFC.HeldenTaverne.Persistence.Implementations.Repositories;

internal class WeatherForecastRepository
    : GenericRepository<WeatherForecast, Guid>, IWeatherForecastRepository
{
    public WeatherForecastRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}