using PlanManager.Application.Commands.PlanCommands;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class EditPlanCommandRequest
{
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Description { get; set; }

    public EditPlanCommandRequest(string name, double longitude, double latitude, string description)
    {
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
        Description = description;
    }

    //We give the plan since its going to sue all of its attributes
    public EditPlanCommand ToApplication(Guid planId, Guid userId)
    {
        return new EditPlanCommand(planId, Name, Longitude, Latitude, Description, userId);
    }
    
    
}