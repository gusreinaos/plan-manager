using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;

namespace PlanManager.Application.Commands.UserCommands;

public class UninviteFriendCommandHandler : IRequestHandler<UninviteFriendCommand, UninviteFriendCommandResponse>
{
    public Task<UninviteFriendCommandResponse> Handle(UninviteFriendCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}