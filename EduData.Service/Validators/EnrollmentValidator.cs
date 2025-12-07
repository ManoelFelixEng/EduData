using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class EnrollmentValidator : AbstractValidator<Enrollment>
    {
        public EnrollmentValidator()
        {
            RuleFor(x => x.Id_Student)
                .GreaterThan(0).WithMessage("Aluno inválido para matrícula.");

            RuleFor(x => x.Id_Class)
                .GreaterThan(0).WithMessage("Turma inválida para matrícula.");

            RuleFor(x => x.Id_College_Subject)
                .GreaterThan(0).WithMessage("Disciplina inválida para matrícula.");


            RuleFor(x => x.Final_Score)
                .GreaterThanOrEqualTo(0).WithMessage("A nota final não pode ser negativa.")
                .LessThanOrEqualTo(10).WithMessage("A nota final não pode ser maior que 10.");
        }
    }
}