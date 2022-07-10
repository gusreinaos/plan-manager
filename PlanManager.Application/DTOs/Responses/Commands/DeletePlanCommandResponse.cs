namespace PlanManager.Application.DTOs.Responses.Commands;

public class DeletePlanCommandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public DeletePlanCommandResponse(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}