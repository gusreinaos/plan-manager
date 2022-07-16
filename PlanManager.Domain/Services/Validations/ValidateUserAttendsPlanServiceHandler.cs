using MediatR;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Domain.Services.Validations;

public class ValidateUserAttendsPlanServiceHandler :  IRequestHandler<ValidateUserAttendsPlanService, bool>
{

    private readonly IUserAttendsPlanRepository _userAttendsPlanRepository;

    public ValidateUserAttendsPlanServiceHandler(IUserAttendsPlanRepository userAttendsPlanRepository)
    {
        _userAttendsPlanRepository = userAttendsPlanRepository;
    }
    
    public async Task<bool> Handle(ValidateUserAttendsPlanService request, CancellationToken cancellationToken)
    {
        var userAttendsPlan = _userAttendsPlanRepository.GetUserAttendsPlanByUserIdAndPlanId(request.UserId, request.PlanId);
        return userAttendsPlan != null;
    }
}