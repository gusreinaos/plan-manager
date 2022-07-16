using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class DeletePlanCommandRequest
{
    public DeletePlanCommand ToApplication(Guid id, Guid userId)
    {
        return new DeletePlanCommand(id, userId);
    }
}