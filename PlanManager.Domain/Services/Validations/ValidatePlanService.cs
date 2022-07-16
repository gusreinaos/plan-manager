using MediatR;

namespace PlanManager.Domain.Services.Validations;

public class ValidatePlanService : IRequest<bool>
{
    public Guid Id { get; set; }

    public ValidatePlanService(Guid id)
    {
        Id = id;
    }
}