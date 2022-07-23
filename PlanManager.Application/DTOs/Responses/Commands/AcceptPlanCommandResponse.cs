namespace PlanManager.Application.DTOs.Responses.Commands;

public class AcceptPlanCommandResponse
{
    public Guid Plan { get; set; }

    public AcceptPlanCommandResponse(Guid plan)
    {
        Plan = plan;
    }
}