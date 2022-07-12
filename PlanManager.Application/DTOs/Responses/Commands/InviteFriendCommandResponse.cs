using PlanManager.Domain.Entities;

namespace PlanManager.Application.DTOs.Responses.Commands;

public class InviteFriendCommandResponse
{
    public List<UserAttendsPlan> UserAttendsPlan { get; set; }
    
    public InviteFriendCommandResponse(List<UserAttendsPlan> userAttendsPlan)
    {
        UserAttendsPlan = userAttendsPlan;
    }
}