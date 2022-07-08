using MediatR;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class EditPlanCommandHandler : IRequestHandler<EditPlanCommand, Plan>
{
    private readonly IPlanRepository _planRepository;

    public EditPlanCommandHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }
    
    public async Task<Plan> Handle(EditPlanCommand request, CancellationToken cancellationToken)
    {
        var oldPlan = _planRepository.GetPlanById(request.PlanId);
        
        oldPlan.Name = request.Plan.Name;
        oldPlan.Description = request.Plan.Description;
        oldPlan.Latitude = request.Plan.Latitude;
        oldPlan.Longitude = request.Plan.Longitude;
        
        _planRepository.UpdatePlan(oldPlan);
        _planRepository.Save();

        return oldPlan;
    }
}