using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class CollegeSubjectValidator : AbstractValidator<College_Subject>
    {
        public CollegeSubjectValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome da disciplina é obrigatório.");

            RuleFor(x => x.Courseload) 
                .GreaterThan(0).WithMessage("A carga horária deve ser maior que zero.");
        }
    }
}