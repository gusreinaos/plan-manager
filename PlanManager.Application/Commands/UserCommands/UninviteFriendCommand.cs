using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;

namespace PlanManager.Application.Commands.UserCommands;

public class UninviteFriendCommand : IRequest<UninviteFriendCommandResponse>
{
    public Guid UserId { get; set; }
    public Guid PlanId { get; set; }
    public UninviteFriendCommand(Guid userId, Guid planId)
    {
        UserId = userId;
        PlanId = planId;
    }
}