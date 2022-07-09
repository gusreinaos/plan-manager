using MediatR;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class ListPlanCommand : IRequest<IEnumerable<Plan>>
{
    public Guid UserId { get; set; }

    public ListPlanCommand(Guid userId)
    {
        UserId = userId;
    }
}