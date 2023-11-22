using JSFC.HeldenTaverne.Domain.Common.Persistence;

namespace JSFC.HeldenTaverne.Application.WeatherForecastService;

internal class WeatherForecastService : IWeatherForecastService
{
    private readonly IUnitOfWork _unitOfWork;

    public WeatherForecastService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public List<WeatherForecast> GetDemoData()
    {
        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        var result = Enumerable.Range(1, 5)
            .Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            })
            .ToList();

        return result;
    }

    public void CreateWeatherForecast(DateTime date, int temperature, string? summary)
    {
        var newWeatherForecast = new WeatherForecast
        {
            Date = date,
            TemperatureC = temperature,
            Summary = summary
        };

        _unitOfWork.WeatherForecastRepository.Add(newWeatherForecast);
        _unitOfWork.SaveChangesAsync();
    }

    public async Task<IList<WeatherForecast>> GetWithTemperatureGreaterThan(int temperature)
    {
        var result = await _unitOfWork.WeatherForecastRepository
            .FindAllAsync(x => x.TemperatureC > temperature);

        return result.ToList();
    }

    public async Task<IList<WeatherForecast>> GetWithTemperatureLowerThan(int temperature)
    {
        var result = await _unitOfWork.WeatherForecastRepository
            .AsQueryable()
            .Where(x => x.TemperatureC < temperature)
            .ToListAsync();

        return result.ToList();
    }
}