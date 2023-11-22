using JSFC.HeldenTaverne.Domain.Common.Persistence;

namespace JSFC.HeldenTaverne.Persistence.Implementations;

internal class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(
        ApplicationDbContext dbContext,
        IWeatherForecastRepository weatherForecastRepository)
    {
        _dbContext = dbContext;
        WeatherForecastRepository = weatherForecastRepository;
    }

    public IWeatherForecastRepository WeatherForecastRepository { get; }

    public async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}