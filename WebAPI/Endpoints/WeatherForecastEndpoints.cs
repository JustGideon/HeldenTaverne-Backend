using JSFC.HeldenTaverne.Application.WeatherForecastService;
using JustGideon.DSA5CharacterManager.WebAPI.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace JustGideon.DSA5CharacterManager.WebAPI.Endpoints;

public class WeatherForecastEndpoints : IEndpointModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/weatherForecast/");

        group.MapGet(
            "",
            GetAllWeatherForecast);
        group.MapGet(
            "greaterThan/{temperature}",
            GetWithTemperatureGreaterThan);
        group.MapGet(
            "lowerThan/{temperature}",
            GetWithTemperatureLowerThan);
        group.MapPost(
            "{date}/{temperature}/{summary}",
            CreateWeatherForecast);
    }

    public static Ok<List<WeatherForecast>> GetAllWeatherForecast(
        IWeatherForecastService weatherForecastService)
    {
        var result = weatherForecastService.GetDemoData();

        return TypedResults.Ok(result);
    }

    public static void CreateWeatherForecast(
        DateTime date,
        int temperature,
        string summary,
        IWeatherForecastService weatherForecastService)
    {
        weatherForecastService.CreateWeatherForecast(
            date,
            temperature,
            summary);
    }

    public static async Task<Ok<IList<WeatherForecast>>> GetWithTemperatureGreaterThan(
        int temperature,
        IWeatherForecastService weatherForecastService)
    {
        var result = await weatherForecastService.GetWithTemperatureGreaterThan(temperature);

        return TypedResults.Ok(result);
    }

    public static async Task<Ok<IList<WeatherForecast>>> GetWithTemperatureLowerThan(
        int temperature,
        IWeatherForecastService weatherForecastService)
    {
        var result = await weatherForecastService.GetWithTemperatureLowerThan(temperature);

        return TypedResults.Ok(result);
    }
}