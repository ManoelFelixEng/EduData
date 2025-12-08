using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class ClassValidator : AbstractValidator<Class>
    {
        public ClassValidator()
        {
            RuleFor(x => x.Course)
                  .NotEmpty().WithMessage("O nome do curso é obrigatório.")
                  .MaximumLength(100).WithMessage("O curso deve ter no máximo 100 caracteres.");

            RuleFor(x => x.Period)
                .GreaterThan(0).WithMessage("O período deve ser maior que zero.");

            RuleFor(x => x.NumberStudents) 
                .GreaterThanOrEqualTo(0).WithMessage("A capacidade de alunos não pode ser negativa.");
        }
    }
}