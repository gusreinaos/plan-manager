using PlanManager.Application.Queries.PlanQueries;

namespace PlanManager.Application.DTOs.Requests.Queries;

public class ListPlanQueryRequest
{
    public ListPlanQuery ToApplication(Guid userId)
    {
        return new ListPlanQuery(userId);
    }
}