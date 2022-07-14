namespace PlanManager.Application.DTOs.Responses.Commands;

public class UninviteFriendCommandResponse
{
    public string FriendEmail { get; set; }
    
    public UninviteFriendCommandResponse(string friendEmail)
    {
        FriendEmail = friendEmail;
    }
}