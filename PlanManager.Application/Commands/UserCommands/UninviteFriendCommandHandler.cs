using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Interfaces;
using PlanManager.Domain.Services.Validations;

namespace PlanManager.Application.Commands.UserCommands;

public class UninviteFriendCommandHandler : IRequestHandler<UninviteFriendCommand, UninviteFriendCommandResponse>
{

    private readonly IUserAttendsPlanRepository _userAttendsPlanRepository;
    private readonly IUserRepository _userRepository;
    private readonly IMediator _mediator;

    public UninviteFriendCommandHandler(IUserAttendsPlanRepository userAttendsPlanRepository, IUserRepository userRepository, IMediator mediator)
    {
        _userAttendsPlanRepository = userAttendsPlanRepository;
        _userRepository = userRepository;
        _mediator = mediator;
    }
    
    
    public async Task<UninviteFriendCommandResponse> Handle(UninviteFriendCommand request, CancellationToken cancellationToken)
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
        if (!userInvited)
        {
            throw new Exception("User with Id " + request.UserId + " is not invited to plan " + request.PlanId);
        }
        
        var userAttendsPlan = _userAttendsPlanRepository.GetUserAttendsPlanByUserIdAndPlanId(request.UserId, request.PlanId);
        _userAttendsPlanRepository.DeleteUserAttendsPlan(userAttendsPlan.Id);

        var friend = _userRepository.GetUserById(request.UserId);
        
        
        return new UninviteFriendCommandResponse(friend.Email);
    }
}