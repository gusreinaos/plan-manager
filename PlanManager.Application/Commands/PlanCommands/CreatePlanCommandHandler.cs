using MediatR;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Commands.PlanCommands;

public class CreatePlanCommandHandler : IRequestHandler<CreatePlanCommand, Plan>
{

    private readonly IUserRepository _userRepository;

    public CreatePlanCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Plan> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
    {
        var plan = _userRepository.GetUserById(Guid.Parse("aaf81b9a-0689-4d76-a61a-1660b490a2a0"));
        return new Plan(plan.Name + " " + request.Name);
    }
}