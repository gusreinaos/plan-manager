using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class EditPlanCommandHandler : IRequestHandler<EditPlanCommand, EditPlanCommandResponse>
{
    private readonly IPlanRepository _planRepository;

    public EditPlanCommandHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }
    
    public async Task<EditPlanCommandResponse> Handle(EditPlanCommand request, CancellationToken cancellationToken)
    {
        var oldPlan = _planRepository.GetPlanById(request.Plan.Id);
        
        oldPlan.Name = request.Plan.Name;
        oldPlan.Description = request.Plan.Description;
        oldPlan.Latitude = request.Plan.Latitude;
        oldPlan.Longitude = request.Plan.Longitude;
        
        _planRepository.UpdatePlan(oldPlan);
        _planRepository.Save();

        return new EditPlanCommandResponse(request.Plan.Name, request.Plan.Longitude, request.Plan.Latitude, request.Plan.Description);
    }
}