using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;
using PlanManager.Domain.Services.Validations;

namespace PlanManager.Application.Commands.PlanCommands;

public class EditPlanCommandHandler : IRequestHandler<EditPlanCommand, EditPlanCommandResponse>
{
    private readonly IPlanRepository _planRepository;
    private readonly IMediator _mediator;

    public EditPlanCommandHandler(IPlanRepository planRepository, IMediator mediator)
    {
        _planRepository = planRepository;
        _mediator = mediator;
    }
    
    public async Task<EditPlanCommandResponse> Handle(EditPlanCommand request, CancellationToken cancellationToken)
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
        
        var oldPlan = _planRepository.GetPlanById(request.Id);

        if (!oldPlan.UserId.Equals(request.UserId))
        {
            throw new Exception("This plan is now owned by user " + request.UserId);
        }
        
        oldPlan.Name = request.Name;
        oldPlan.Description = request.Description;
        oldPlan.Latitude = request.Latitude;
        oldPlan.Longitude = request.Longitude;
        
        _planRepository.UpdatePlan(oldPlan);
        _planRepository.Save();

        return new EditPlanCommandResponse(request.Name, request.Longitude, request.Latitude, request.Description);
    }
}