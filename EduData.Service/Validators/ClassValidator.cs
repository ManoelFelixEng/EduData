using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class ClassValidator : AbstractValidator<Class>
    {
        public ClassValidator()
        {
            RuleFor(x => x.Course)
                  .NotEmpty().WithMessage("The course name is required.")
                  .MaximumLength(50).WithMessage("The course should have a maximum of 50 characters.");

            RuleFor(x => x.Period)
                .GreaterThan(0).WithMessage("The period must be greater than zero.");

            RuleFor(x => x.NumberStudents) 
                .GreaterThanOrEqualTo(0).WithMessage("The ability of students cannot be negative.");
        }
    }
}