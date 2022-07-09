using MediatR;
using PlanManager.Application.DTOs.Responses.Queries;

namespace PlanManager.Application.Queries.PlanQueries;

public class ListPlanQuery : IRequest<ListPlanQueryResponse>
{
    public Guid UserId { get; set; }

    public ListPlanQuery(Guid userId)
    {
        UserId = userId;
    }
}