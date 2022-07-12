using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.UserCommands;

public class InviteFriendCommand : IRequest<InviteFriendCommandResponse>
{
    public Guid UserId { get; set; }
    public Guid PlanId { get; set; }
    public string FriendId { get; set; }
    public InviteFriendCommand(Guid userId, Guid planId, string friendId)
    {
        UserId = userId;
        PlanId = planId;
        FriendId = friendId;
    }

    
}