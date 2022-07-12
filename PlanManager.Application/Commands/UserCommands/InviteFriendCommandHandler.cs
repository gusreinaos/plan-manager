using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.UserCommands;

public class InviteFriendCommandHandler : IRequestHandler<InviteFriendCommand, InviteFriendCommandResponse>
{
    private readonly IPlanRepository _planRepository;
    
    public Task<InviteFriendCommandResponse> Handle(InviteFriendCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}