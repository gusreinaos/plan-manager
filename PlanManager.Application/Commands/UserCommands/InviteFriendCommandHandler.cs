using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.UserCommands;

public class InviteFriendCommandHandler : IRequestHandler<InviteFriendCommand, InviteFriendCommandResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IUserAttendsPlanRepository _userAttendsPlanRepository;

    public InviteFriendCommandHandler(IUserRepository userRepository, IUserAttendsPlanRepository userAttendsPlanRepository)
    {
        _userRepository = userRepository;
        _userAttendsPlanRepository = userAttendsPlanRepository;
    }
    
    public async Task<InviteFriendCommandResponse> Handle(InviteFriendCommand request, CancellationToken cancellationToken)
    {

        var friend = _userRepository.GetUserById(request.UserId);

        var userAttendsPlan = new UserAttendsPlan(new int(), request.UserId, request.PlanId);
        
        _userAttendsPlanRepository.CreateUserAttendsPlan(userAttendsPlan);
        _userAttendsPlanRepository.Save();
        
        //Send Email via EmailJet
        
        return new InviteFriendCommandResponse(friend.Email);
    }
}