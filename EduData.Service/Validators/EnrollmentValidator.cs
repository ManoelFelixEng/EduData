using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class EnrollmentValidator : AbstractValidator<Enrollment>
    {
        public EnrollmentValidator()
        {
            RuleFor(x => x.IdStudent)
                .GreaterThan(0).WithMessage("Aluno inválido para matrícula.");

            RuleFor(x => x.IdClass)
                .GreaterThan(0).WithMessage("Turma inválida para matrícula.");

            RuleFor(x => x.IdCollegeSubject)
                .GreaterThan(0).WithMessage("Disciplina inválida para matrícula.");

            
            RuleFor(x => x.FinalScore)
                .GreaterThanOrEqualTo(0).When(x => x.FinalScore.HasValue)
                .WithMessage("A nota final não pode ser negativa.");
        }
    }
}