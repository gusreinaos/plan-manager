using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class DeletePlanCommandRequest
{
    public DeletePlanCommand ToApplication(Guid id)
    {
        return new DeletePlanCommand(id);
    }
}