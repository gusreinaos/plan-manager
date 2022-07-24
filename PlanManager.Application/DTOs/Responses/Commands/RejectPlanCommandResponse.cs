namespace PlanManager.Application.DTOs.Responses.Commands;

public class RejectPlanCommandResponse
{
    public Guid PlanId { get; set; }

    public RejectPlanCommandResponse(Guid planId)
    {
        PlanId = planId;
    }
}