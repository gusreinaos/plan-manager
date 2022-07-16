using MediatR;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Domain.Services.Validations;

public class ValidatePlanServiceHandler :  IRequestHandler<ValidatePlanService, bool>
{
    private readonly IPlanRepository _planRepository;

    public ValidatePlanServiceHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }
    
    public async Task<bool> Handle(ValidatePlanService request, CancellationToken cancellationToken)
    {
        var plan = _planRepository.GetPlanById(request.Id);
        return plan != null;
    }
}