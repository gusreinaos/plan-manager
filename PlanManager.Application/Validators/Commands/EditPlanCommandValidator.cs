using FluentValidation;
using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.Validators.Commands;

public class EditPlanCommandValidator : AbstractValidator<EditPlanCommand>
{
    public EditPlanCommandValidator()
    {
        RuleFor(e => e.Name).NotEmpty().MaximumLength(20);
        RuleFor(e => e.Description).NotEmpty().MaximumLength(50);
        RuleFor(e => e.Latitude).LessThan(180).GreaterThan(-180);
        RuleFor(e => e.Longitude).LessThan(180).GreaterThan(-180);
    }
}