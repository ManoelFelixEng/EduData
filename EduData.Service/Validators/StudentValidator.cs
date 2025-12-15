using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The student's name is required.")
                .MaximumLength(100).WithMessage("The name must have a maximum of 100 characters.");

            RuleFor(x => x.DateBirth) 
                .NotEmpty().WithMessage("Date of birth is required.")
                .LessThan(DateTime.Now).WithMessage("A data de nascimento deve ser no passado.");

            
            RuleFor(x => x.Class)
                .NotNull().WithMessage("It is necessary to link the student to a valid class.");
        }
    }
}