using MediatR;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class DeletePlanCommand : IRequest<DeletePlanCommandResponse>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    
    public DeletePlanCommand(Guid id, Guid userId)
    {
        Id = id;
        UserId = userId;
    }
}