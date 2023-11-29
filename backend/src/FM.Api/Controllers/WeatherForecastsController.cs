using FM.Application.UseCases.WeatherForecasts.GetWeatherForecasts;
using FM.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FM.Api.Controllers;

[ApiController]
[Route("weather-forecasts")]
public class WeatherForecastsController : ApiControllerBase
{
    [HttpGet]
    public Task<WeatherForecast[]> Get()
        => Sender.Send(new GetWeatherForecastsQuery());
}
