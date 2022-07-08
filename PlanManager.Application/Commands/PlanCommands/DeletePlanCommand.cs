using MediatR;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class DeletePlanCommand : IRequest<Plan>
{
    public Guid PlanId { get; set; }
    
    public DeletePlanCommand(Guid planId)
    {
        PlanId = planId;
    }
}