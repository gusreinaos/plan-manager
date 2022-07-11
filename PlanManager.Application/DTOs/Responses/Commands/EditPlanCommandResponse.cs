using PlanManager.Application.Commands.PlanCommands;
using PlanManager.Application.DTOs.Requests.Commands;

namespace PlanManager.Application.DTOs.Responses.Commands;

public class EditPlanCommandResponse
{
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Description { get; set; }

    public EditPlanCommandResponse(string name, double longitude, double latitude, string description)
    {
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
        Description = description;
    }
}