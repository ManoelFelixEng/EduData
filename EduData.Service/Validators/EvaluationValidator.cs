using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class EvaluationValidator : AbstractValidator<Evaluation>
    {
        public EvaluationValidator()
        {
            RuleFor(x => x.NameEvaluation) 
                            .NotEmpty().WithMessage("O nome da avaliação é obrigatório.");

            RuleFor(x => x.ScoreValue) 
                .GreaterThanOrEqualTo(0).WithMessage("O valor da nota não pode ser negativo.")
                .LessThanOrEqualTo(100).WithMessage("A nota máxima permitida é 100.");

            RuleFor(x => x.DateEvaluation) 
                .NotEmpty().WithMessage("A data da avaliação é obrigatória.");
        }
    }
}