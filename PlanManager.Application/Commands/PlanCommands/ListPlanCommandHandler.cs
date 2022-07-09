using MediatR;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class ListPlanCommandHandler : IRequestHandler<ListPlanCommand, IEnumerable<Plan>>
{
    private readonly IPlanRepository _planRepository;

    public ListPlanCommandHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }
    
    public async Task<IEnumerable<Plan>> Handle(ListPlanCommand request, CancellationToken cancellationToken)
    {
        var plans = _planRepository.GetPlanByUserId(request.UserId);
        return plans;
    }
}