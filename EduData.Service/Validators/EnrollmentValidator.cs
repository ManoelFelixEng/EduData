using EduData.Domain.Entities;
using FluentValidation;
using System.Xml.Linq;

namespace EduData.Service.Validators
{
    public class EnrollmentValidator : AbstractValidator<Enrollment>
    {
        public EnrollmentValidator()
        {
            RuleFor(e => e.FinalScore)
                .NotNull().WithMessage("A nota final é obrigatória (mesmo que seja 0).");

            // Validação dos Relacionamentos
            RuleFor(e => e.Student)
                .NotEmpty().WithMessage("Informe o Aluno da matrícula.");

            RuleFor(e => e.Class)
                .NotEmpty().WithMessage("Informe a Turma da matrícula.");

            RuleFor(e => e.CollegeSubject)
                .NotEmpty().WithMessage("Informe a Disciplina da matrícula.");
        }
    }
}