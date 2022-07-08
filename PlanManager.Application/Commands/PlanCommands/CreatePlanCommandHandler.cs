using MediatR;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class CreatePlanCommandHandler : IRequestHandler<CreatePlanCommand, Plan>
{

    private readonly IPlanRepository _planRepository;

    public CreatePlanCommandHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }

    public async Task<Plan> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
    {
        var plan = new Plan(Guid.NewGuid(), request.Name, request.Longitude, request.Latitude, request.Description, request.UserId );
        _planRepository.CreatePlan(plan);
        _planRepository.Save();
        return plan;
    }
}