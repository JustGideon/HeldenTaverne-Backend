namespace JSFC.HeldenTaverne.Application.WeatherForecastService;

public interface IWeatherForecastService
{
    public List<WeatherForecast> GetDemoData();
    public void CreateWeatherForecast(DateTime date, int temperature, string? summary);
    public Task<IList<WeatherForecast>> GetWithTemperatureGreaterThan(int temperature);
    public Task<IList<WeatherForecast>> GetWithTemperatureLowerThan(int temperature);
}