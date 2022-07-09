using MediatR;
using PlanManager.Application.DTOs.Responses;
using PlanManager.Application.Queries.PlanQueries;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Application.Queries.PlanQueries;

public class ListPlanQueryHandler : IRequestHandler<ListPlanQuery, ListPlanQueryResponse>
{
    private readonly IPlanRepository _planRepository;

    public ListPlanQueryHandler(IPlanRepository planRepository)
    {
        _planRepository = planRepository;
    }
    
    public async Task<ListPlanQueryResponse> Handle(ListPlanQuery request, CancellationToken cancellationToken)
    {
        var plans = _planRepository.GetPlansByUserId(request.UserId);
        return new ListPlanQueryResponse(plans);
    }
}