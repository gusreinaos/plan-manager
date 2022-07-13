using MediatR;
using PlanManager.Application.DTOs.Responses;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class CreatePlanCommandHandler : IRequestHandler<CreatePlanCommand, CreatePlanCommandResponse>
{

    private readonly IPlanRepository _planRepository;
    private readonly IUserAttendsPlanRepository _userAttendsPlanRepository;

    public CreatePlanCommandHandler(IPlanRepository planRepository, IUserAttendsPlanRepository userAttendsPlanRepository)
    {
        _planRepository = planRepository;
        _userAttendsPlanRepository = userAttendsPlanRepository;
    }

    public async Task<CreatePlanCommandResponse> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
    {
        //Creation of the plan
        var plan = new Plan(Guid.NewGuid(), request.Name, request.Longitude, request.Latitude, request.Description, request.UserId );
        _planRepository.CreatePlan(plan);
        _planRepository.Save();

        //Creation of the association of the user to the plan
        var userAttendsPlan = new UserAttendsPlan(new int(), request.UserId, plan.Id);
        _userAttendsPlanRepository.CreateUserAttendsPlan(userAttendsPlan);
        _userAttendsPlanRepository.Save();
        
        return new CreatePlanCommandResponse(plan.Id);
    }
}