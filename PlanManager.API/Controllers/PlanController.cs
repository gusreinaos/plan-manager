using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlanManager.Application.DTOs.Requests.Commands;
using PlanManager.Application.DTOs.Requests.Queries;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Application.DTOs.Responses.Queries;

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
    public async Task<InviteFriendCommandResponse> CreatePlan([FromBody] InviteFriendCommandRequest request)
    {
        var userId = Guid.Parse("5da8c826-cb6e-4e1a-bb0a-d4ff136c7181");
        var planId = Guid.Parse("ec30500f-f7c8-4ee4-9f13-ebb7ee7ffbe2");
        var command = request.ToApplication(userId, planId);
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

    [HttpDelete]
    public async Task<DeletePlanCommandResponse> DeletePlan(DeletePlanCommandRequest request)
    {

        var planId = Guid.Parse("027a8160-937d-43e1-9949-fb8e1d2e9aa8");
        var command = request.ToApplication(planId);
        var response = await _mediator.Send(command);

        return response;
    }
}