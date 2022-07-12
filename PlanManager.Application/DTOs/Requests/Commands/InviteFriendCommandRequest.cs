

using PlanManager.Application.Commands.UserCommands;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class InviteFriendCommandRequest
{
    public string FriendMail { get; set; }

    public InviteFriendCommandRequest(string friendMail)
    {
        FriendMail = friendMail;
    }

    public InviteFriendCommand ToApplication(Guid userId, Guid planId)
    {
        return new InviteFriendCommand(userId, planId, FriendMail);
    }
    
    
    
}