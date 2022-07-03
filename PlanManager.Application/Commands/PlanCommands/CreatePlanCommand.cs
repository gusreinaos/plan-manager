using MediatR;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class CreatePlanCommand : IRequest<Plan>
{
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Description { get; set; }

    public CreatePlanCommand(string name, double longitude, double latitude, string description)
    {
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
        Description = description;
    }
}