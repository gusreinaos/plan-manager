using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;

namespace PlanManager.Application.Commands.PlanCommands;

public class AcceptPlanCommand : IRequest<AcceptPlanCommandResponse>
{
    public Guid UserId { get; set; }
    public Guid PlanId { get; set; }

    public AcceptPlanCommand(Guid userId, Guid planId)
    {
        UserId = userId;
        PlanId = planId;
    }
}