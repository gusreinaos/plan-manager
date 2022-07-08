using MediatR;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class DeletePlanCommandHandler : IRequestHandler<DeletePlanCommand, Plan>
{
    private readonly IPlanRepository _planRepository;

    public DeletePlanCommandHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }
    
    public async Task<Plan> Handle(DeletePlanCommand request, CancellationToken cancellationToken)
    {   
        var plan = _planRepository.GetPlanById(request.PlanId);
        _planRepository.DeletePlan(request.PlanId);
        _planRepository.Save();
        return plan;
    }
}