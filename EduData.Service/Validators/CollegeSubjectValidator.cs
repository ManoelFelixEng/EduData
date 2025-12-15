using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class CollegeSubjectValidator : AbstractValidator<CollegeSubject>
    {
        public CollegeSubjectValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The subject name is required.");

            RuleFor(x => x.CourseLoad) 
                .GreaterThan(0).WithMessage("The workload must be greater than zero.");
        }
    }
}