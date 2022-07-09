using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.DTOs.Requests.Commands;

public class CreatePlanCommandRequest
{
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Description { get; set; }

    public CreatePlanCommandRequest(string name, double longitude, double latitude, string description)
    {
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
        Description = description;
    }

    public CreatePlanCommand ToApplication(Guid userId)
    {
        return new CreatePlanCommand(userId, Name, Longitude, Latitude, Description);
    }
}