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
        var user = _userRepository.GetUser();
        return new Plan(user + " " + request.Name);
    }
}