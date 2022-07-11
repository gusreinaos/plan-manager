using MediatR;
using PlanManager.Application.DTOs.Requests.Commands;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class EditPlanCommand : IRequest<EditPlanCommandResponse>
{
    public Plan Plan { get; set; }

    public EditPlanCommand(Plan plan)
    {
        Plan = plan;
    }
    
}