using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;
using PlanManager.Domain.Services.Validations;

namespace PlanManager.Application.Commands.PlanCommands;

public class DeletePlanCommandHandler : IRequestHandler<DeletePlanCommand, DeletePlanCommandResponse>
{
    private readonly IPlanRepository _planRepository;
    private readonly IMediator _mediator;

    public DeletePlanCommandHandler(IPlanRepository planRepository, IMediator mediator)
    {
        _planRepository = planRepository;
        _mediator = mediator;
    }
    
    public async Task<DeletePlanCommandResponse> Handle(DeletePlanCommand request, CancellationToken cancellationToken)
    {   
        
        var userExists = await _mediator.Send(new ValidateUserService(request.UserId));
        if (!userExists)
        {
            throw new Exception("User with " + request.UserId + " does not exist.");
        }
        
        var planExists = await _mediator.Send(new ValidatePlanService(request.Id));
        if (!planExists)
        {
            throw new Exception("Plan with " + request.Id + " does not exist.");
        }
        
        var plan = _planRepository.GetPlanById(request.Id);
        if (!plan.UserId.Equals(request.UserId))
        {
            throw new Exception("This plan is now owned by user " + request.UserId);
        }
        
        _planRepository.DeletePlan(request.Id);
        _planRepository.Save();
        return new DeletePlanCommandResponse(plan.Id, plan.Name);
    }
}