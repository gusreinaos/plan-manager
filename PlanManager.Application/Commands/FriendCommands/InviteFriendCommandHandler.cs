using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;

namespace PlanManager.Application.Commands.FriendCommands;

public class InviteFriendCommandHandler : IRequestHandler<InviteFriendCommand, InviteFriendCommandResponse>
{
    public Task<InviteFriendCommandResponse> Handle(InviteFriendCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}