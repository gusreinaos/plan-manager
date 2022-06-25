using MediatR;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class CreatePlanCommand : IRequest<Plan>
{
    public string Name;

    public CreatePlanCommand(string name)
    {
        Name = name;
    }
    
}