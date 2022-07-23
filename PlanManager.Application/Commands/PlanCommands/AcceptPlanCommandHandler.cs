using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Constants;
using PlanManager.Domain.Interfaces;
using PlanManager.Domain.Services.Validations;

namespace PlanManager.Application.Commands.PlanCommands;

public class AcceptPlanCommandHandler : IRequestHandler<AcceptPlanCommand, AcceptPlanCommandResponse>
{

    private readonly IMediator _mediator;
    private readonly IUserAttendsPlanRepository _userAttendsPlanRepository;
    private readonly IPlanRepository _planRepository;

    public AcceptPlanCommandHandler(IMediator mediator, IUserAttendsPlanRepository userAttendsPlanRepository, IPlanRepository planRepository)
    {
        _mediator = mediator;
        _userAttendsPlanRepository = userAttendsPlanRepository;
        _planRepository = planRepository;
    }

    public async Task<AcceptPlanCommandResponse> Handle(AcceptPlanCommand request, CancellationToken cancellationToken)
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
            throw new Exception("You cannot accept a plan you are not invited to");
        }
        
        var userAttendsPlan = _userAttendsPlanRepository.GetUserAttendsPlanByUserIdAndPlanId(request.UserId, request.PlanId);
        userAttendsPlan.Status = UserAttendsPlanStatus.Accepted;
        _userAttendsPlanRepository.UpdateUserAttendsPlan(userAttendsPlan);
        _userAttendsPlanRepository.Save();
        
        return new AcceptPlanCommandResponse(request.PlanId);
    }
}