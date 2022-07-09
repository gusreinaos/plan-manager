using FluentValidation;
using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.Validators.Commands;

public class CreatePlanCommandValidator : AbstractValidator<CreatePlanCommand>
{
    public CreatePlanCommandValidator()
    {
        RuleFor(t => t.Name).NotEmpty().MaximumLength(20);
        RuleFor(t => t.Description).NotEmpty().MaximumLength(50);
        RuleFor(t => t.Latitude).LessThan(180).GreaterThan(-180);
        RuleFor(t => t.Longitude).LessThan(180).GreaterThan(-180);
    }
    
}