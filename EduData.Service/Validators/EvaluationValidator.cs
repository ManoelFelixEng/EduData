using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class EvaluationValidator : AbstractValidator<Evaluation>
    {
        public EvaluationValidator()
        {
            RuleFor(x => x.NameEvaluation) 
                            .NotEmpty().WithMessage("The name of the evaluation is required.");

            RuleFor(x => x.ScoreValue) 
                .GreaterThanOrEqualTo(0).WithMessage("The value of the grade cannot be negative.")
                .LessThanOrEqualTo(100).WithMessage("The maximum grade allowed is 100.");

            RuleFor(x => x.DateEvaluation) 
                .NotEmpty().WithMessage("The evaluation date is mandatory.");
        }
    }
}