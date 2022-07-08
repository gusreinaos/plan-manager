using MediatR;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class EditPlanCommand : IRequest<Plan>
{
    public Guid PlanId { get; set; }
    public Plan Plan { get; set; }
    
    public EditPlanCommand(Guid planId, Plan plan)
    {
        PlanId = planId;
        Plan = plan;
    }
}