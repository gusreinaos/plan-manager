using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlanManager.Application.Commands.PlanCommands;
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

    //Cada vez que creemos el caso de uso tenemos que especificar la accion http a la que se refiere
    
    [HttpPost]
    public async Task<CreatePlanCommandResponse> CreatePlan([FromBody] CreatePlanCommandRequest request)
    {
        var userId = Guid.Parse("b5ad7569-b94b-4808-99cd-cb2f3cab0e3a");
        var command = request.ToApplication(userId);
        var response = await _mediator.Send(command);

        return response;
    }
    
    [HttpPut]
    [Route("{planId:guid}")]
    public async Task<EditPlanCommandResponse> EditPlan([FromBody] EditPlanCommandRequest request, Guid planId)
    {
        var userId = Guid.Parse("b5ad7569-b94b-4808-99cd-cb2f3cab0e3a");
        var command = request.ToApplication(userId, planId);
        var response = await _mediator.Send(command);

        return response;
    }

    [HttpDelete]
    [Route("{planId:guid}")]
    public async Task<DeletePlanCommandResponse> DeletePlan(Guid planId)
    {
        var userId = Guid.Parse("b5ad7569-b94b-4808-99cd-cb2f3cab0e3a");
        var command = new DeletePlanCommandRequest().ToApplication(planId, userId);
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