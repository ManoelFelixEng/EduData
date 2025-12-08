using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class CollegeSubjectValidator : AbstractValidator<CollegeSubject>
    {
        public CollegeSubjectValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome da disciplina é obrigatório.");

            RuleFor(x => x.CourseLoad) 
                .GreaterThan(0).WithMessage("A carga horária deve ser maior que zero.");
        }
    }
}