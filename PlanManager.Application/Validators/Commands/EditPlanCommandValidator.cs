using FluentValidation;
using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.Validators.Commands;

public class EditPlanCommandValidator : AbstractValidator<EditPlanCommand>
{
    public EditPlanCommandValidator()
    {
        RuleFor(e => e.Plan.Name).NotEmpty().MaximumLength(20);
        RuleFor(e => e.Plan.Description).NotEmpty().MaximumLength(50);
        RuleFor(e => e.Plan.Latitude).LessThan(180).GreaterThan(-180);
        RuleFor(e => e.Plan.Longitude).LessThan(180).GreaterThan(-180);
    }
}