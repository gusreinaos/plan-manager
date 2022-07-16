using MediatR;
using PlanManager.Application.DTOs.Requests.Commands;
using PlanManager.Application.DTOs.Responses.Commands;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.Commands.PlanCommands;

public class EditPlanCommand : IRequest<EditPlanCommandResponse>
{

    public Guid  Id { get; set; }
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Description { get; set; }
    public Guid UserId { get; set; }

    public EditPlanCommand(Guid id, string name, double longitude, double latitude, string description, Guid userId)
    {
        Id = id;
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
        Description = description;
        UserId = userId;
    }
}