using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome do aluno é obrigatório.")
                .MaximumLength(100).WithMessage("O nome deve ter no máximo 100 caracteres.");

            RuleFor(x => x.DateBirth)
                .NotEmpty().WithMessage("A data de nascimento é obrigatória.")
                .LessThan(DateTime.Now).WithMessage("A data de nascimento deve ser no passado.");

            RuleFor(x => x.IdClass)
                .GreaterThan(0).WithMessage("É necessário vincular o aluno a uma turma válida.");
        }
    }
}