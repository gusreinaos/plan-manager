using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlanManager.Application.Commands.PlanCommands;
using PlanManager.Domain.Interfaces;

namespace PlanManager.API.Controllers;

[ApiController]
[Route("weather-forecast")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    private IMediator _mediator;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        var plan = await _mediator.Send(new CreatePlanCommand("oscar2", 40, -50, "pepe"));
        
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = ""
            })
            .ToArray();
    }
}