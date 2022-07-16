using PlanManager.Application.Commands.UserCommands;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class UninviteFriendCommandRequest
{
    public UninviteFriendCommand ToApplication(Guid userId, Guid planId)
    {
        return new UninviteFriendCommand(userId, planId);
    }
}