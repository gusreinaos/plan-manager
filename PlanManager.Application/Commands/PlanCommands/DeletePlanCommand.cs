using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class DeletePlanCommand : IRequest<DeletePlanCommandResponse>
{
    public Guid PlanId { get; set; }
    
    public DeletePlanCommand(Guid planId)
    {
        PlanId = planId;
    }
}