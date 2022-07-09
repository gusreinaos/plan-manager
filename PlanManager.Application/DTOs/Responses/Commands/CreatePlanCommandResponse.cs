namespace PlanManager.Application.DTOs.Responses.Commands;

public class CreatePlanCommandResponse
{
    public Guid Id { get; set; }

    public CreatePlanCommandResponse(Guid id)
    {
        Id = id;
    }
}