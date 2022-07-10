using FluentValidation;
using PlanManager.Application.Queries.PlanQueries;

namespace PlanManager.Application.Validators.Queries;

public class ListPlansQueryValidator : AbstractValidator<ListPlanQuery>
{
    
    public ListPlansQueryValidator()
    {
        //Validator for the Guid of the user id
        
    }
}