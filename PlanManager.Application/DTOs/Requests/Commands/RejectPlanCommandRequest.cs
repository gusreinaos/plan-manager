using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class RejectPlanCommandRequest
{
    public RejectPlanCommand ToApplication(Guid userId, Guid planId)
    {
        return new RejectPlanCommand(userId, planId);
    }
}