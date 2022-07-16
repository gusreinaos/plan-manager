using MediatR;

namespace PlanManager.Domain.Services.Validations;

public class ValidateUserService : IRequest<bool>
{
    public Guid Id { get; set; }

    public ValidateUserService(Guid id)
    {
        Id = id;
    }
}