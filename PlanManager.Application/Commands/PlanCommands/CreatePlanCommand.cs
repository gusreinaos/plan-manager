using MediatR;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class CreatePlanCommand : IRequest<Plan>
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Description { get; set; }

    public CreatePlanCommand(Guid userId, string name, double longitude, double latitude, string description)
    {
        UserId = userId;
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
        Description = description;
    }
}