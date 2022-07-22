using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Constants;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;
using PlanManager.Domain.Services.Validations;

namespace PlanManager.Application.Commands.UserCommands;

public class InviteFriendCommandHandler : IRequestHandler<InviteFriendCommand, InviteFriendCommandResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IUserAttendsPlanRepository _userAttendsPlanRepository;
    private readonly IMediator _mediator;

    public InviteFriendCommandHandler(IUserRepository userRepository, IUserAttendsPlanRepository userAttendsPlanRepository, IMediator mediator)
    {
        _userRepository = userRepository;
        _userAttendsPlanRepository = userAttendsPlanRepository;
        _mediator = mediator;
    }
    
    public async Task<InviteFriendCommandResponse> Handle(InviteFriendCommand request, CancellationToken cancellationToken)
    {
        var userExists = await _mediator.Send(new ValidateUserService(request.UserId));
        if (!userExists)
        {
            throw new Exception("User with " + request.UserId + " does not exist.");
        }
        
        var planExists = await _mediator.Send(new ValidatePlanService(request.PlanId));
        if (!planExists)
        {
            throw new Exception("Plan with " + request.PlanId + " does not exist.");
        }

        var userInvited = await _mediator.Send(new ValidateUserAttendsPlanService(request.PlanId, request.UserId));
        if (userInvited)
        {
            throw new Exception("User with " + request.UserId + " is already invited to this plan.");
        }
        
        var friend = _userRepository.GetUserById(request.UserId);

        var userAttendsPlan = new UserAttendsPlan(new int(), request.UserId, request.PlanId, UserAttendsPlanStatus.Tentative);
        
        _userAttendsPlanRepository.CreateUserAttendsPlan(userAttendsPlan);
        _userAttendsPlanRepository.Save();
        
        //Send Email via EmailJet
        
        return new InviteFriendCommandResponse(friend.Email);
    }
}