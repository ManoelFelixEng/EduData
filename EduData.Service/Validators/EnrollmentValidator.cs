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
                .NotNull().WithMessage("The final grade is mandatory (even if it's 0).");

            
            RuleFor(e => e.Student)
                .NotEmpty().WithMessage("Inform the student of their enrollment number.");

            RuleFor(e => e.Class)
                .NotEmpty().WithMessage("Please provide the class name for enrollment.");

            RuleFor(e => e.CollegeSubject)
                .NotEmpty().WithMessage("Please specify the course you are enrolled in.");
        }

    }
}