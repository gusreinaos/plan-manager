using FluentValidation;
using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.Application.Validators.Commands;

public class EditPlanCommandValidator : AbstractValidator<EditPlanCommand>
{
    public EditPlanCommandValidator()
    {
        
    }
}