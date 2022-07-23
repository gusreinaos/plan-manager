using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;

namespace PlanManager.Application.Commands.PlanCommands;

public class RejectPlanCommand : IRequest<RejectPlanCommandResponse>
{
    public Guid UserId { get; set; }
    public Guid PlanId { get; set; }

    public RejectPlanCommand(Guid userId, Guid planId)
    {
        UserId = userId;
        PlanId = planId;
    }
}