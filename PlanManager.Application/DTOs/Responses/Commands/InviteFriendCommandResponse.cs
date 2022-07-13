using PlanManager.Domain.Entities;

namespace PlanManager.Application.DTOs.Responses.Commands;

public class InviteFriendCommandResponse
{
    public string FriendEmail { get; set; }
    
    public InviteFriendCommandResponse(string friendEmail)
    {
        FriendEmail = friendEmail;
    }
}