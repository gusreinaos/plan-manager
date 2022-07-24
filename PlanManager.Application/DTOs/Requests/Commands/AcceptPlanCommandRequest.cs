using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class AcceptPlanCommandRequest
{

    public AcceptPlanCommand ToApplication(Guid userId, Guid planId)
    {
        return new AcceptPlanCommand(userId, planId);
    }
}