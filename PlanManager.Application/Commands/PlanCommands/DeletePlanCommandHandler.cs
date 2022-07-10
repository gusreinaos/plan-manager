using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class DeletePlanCommandHandler : IRequestHandler<DeletePlanCommand, DeletePlanCommandResponse>
{
    private readonly IPlanRepository _planRepository;

    public DeletePlanCommandHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }
    
    public async Task<DeletePlanCommandResponse> Handle(DeletePlanCommand request, CancellationToken cancellationToken)
    {   
        var plan = _planRepository.GetPlanById(request.PlanId);
        _planRepository.DeletePlan(request.PlanId);
        _planRepository.Save();
        return new DeletePlanCommandResponse(plan.Id, plan.Name);
    }
}