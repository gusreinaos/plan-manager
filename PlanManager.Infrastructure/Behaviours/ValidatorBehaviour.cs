using FluentValidation;
using MediatR;

namespace PlanManager.Infrastructure.Behaviours;

public class ValidatorBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : MediatR.IRequest<TResponse>
{
    private readonly IValidator<TRequest>[] _validators;

    public ValidatorBehaviour(IValidator<TRequest>[] validator)
    {
        _validators = validator;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        if (!_validators.Any())
        {
            //If no validator found for a specific command/query then continue
            return await next();
        }

        var failures = _validators
            .Select(v => v.Validate(request))
            .SelectMany(result => result.Errors)
            .Where(error => error != null)
            .ToList();

        if (!failures.Any())
        {
            return await next();
        }
        
        throw new Exception("Some validation errors were found");
    }
}