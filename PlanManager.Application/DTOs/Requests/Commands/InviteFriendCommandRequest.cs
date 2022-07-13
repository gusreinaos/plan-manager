

using PlanManager.Application.Commands.UserCommands;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class InviteFriendCommandRequest
{
    public InviteFriendCommand ToApplication(Guid userId, Guid planId)
    {
        return new InviteFriendCommand(userId, planId);
    }
}