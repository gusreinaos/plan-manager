using PlanManager.Application.Commands.PlanCommands;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class EditPlanCommandRequest
{
    
    //We give the plan since its going to sue all of its attributes
    public EditPlanCommand ToApplication(Plan plan)
    {
        return new EditPlanCommand(plan);
    }
    
    
}