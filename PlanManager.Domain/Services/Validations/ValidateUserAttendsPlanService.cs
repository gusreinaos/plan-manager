using MediatR;

namespace PlanManager.Domain.Services.Validations;

public class ValidateUserAttendsPlanService : IRequest<bool>
{
    public Guid PlanId { get; set; }
    public Guid UserId { get; set; }

    public ValidateUserAttendsPlanService(Guid planId, Guid userId)
    {
        PlanId = planId;
        UserId = userId;
    }
}