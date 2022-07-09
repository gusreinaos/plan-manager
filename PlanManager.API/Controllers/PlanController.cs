using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlanManager.Application.Commands.PlanCommands;
using PlanManager.Application.DTOs.Requests;
using PlanManager.Application.DTOs.Responses;
using PlanManager.Domain.Interfaces;

namespace PlanManager.API.Controllers;

[ApiController]
[Route("plans")]
public class PlanController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PlanController> _logger;

    private IMediator _mediator;
    public PlanController(ILogger<PlanController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    /*
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        //var plan = await _mediator.Send(new CreatePlanCommand("oscar2", 40, -50, "pepe"));
        
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = ""
            })
            .ToArray();
    }
    */
    
    //Cada vez que creemos el caso de uso tenemos que especificar la accion http a la que se refiere
    [HttpPost]
    public async Task<CreatePlanCommandResponse> CreatePlan([FromBody] CreatePlanCommandRequest request)
    {
        var userId = Guid.Parse("b5ad7569-b94b-4808-99cd-cb2f3cab0e3a");
        var command = request.ToApplication(userId);
        var response = await _mediator.Send(command);

        return response;
    }

    [HttpGet]
    public async Task<ListPlanQueryResponse> ListPlan()
    {
        var userId = Guid.Parse("b5ad7569-b94b-4808-99cd-cb2f3cab0e3a");
        var query = new ListPlanQueryRequest().ToApplication(userId);
        var response = await _mediator.Send(query);
        
        return response;
    }
}