using PlanManager.Application.Queries.PlanQueries;
using PlanManager.Domain.Entities;

namespace PlanManager.Application.DTOs.Responses.Queries;

public class ListPlanQueryResponse
{
    public IEnumerable<ListPlanQueryPlan> Plans { get; set; }

    public ListPlanQueryResponse(IEnumerable<Plan> plans)
    {
        Plans = plans.Select(p => new ListPlanQueryPlan(p.Id, p.Name));
    }
}

//Used to map the response for the list of plans
public class ListPlanQueryPlan
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ListPlanQueryPlan(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}