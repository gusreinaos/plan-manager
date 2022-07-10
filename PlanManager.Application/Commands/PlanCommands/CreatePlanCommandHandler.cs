using MediatR;
using PlanManager.Application.DTOs.Responses;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class CreatePlanCommandHandler : IRequestHandler<CreatePlanCommand, CreatePlanCommandResponse>
{

    private readonly IPlanRepository _planRepository;

    public CreatePlanCommandHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }

    public async Task<CreatePlanCommandResponse> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
    {
        var plan = new Plan(Guid.NewGuid(), request.Name, request.Longitude, request.Latitude, request.Description, request.UserId );
        _planRepository.CreatePlan(plan);
        _planRepository.Save();
        return new CreatePlanCommandResponse(plan.Id);
    }
}