using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Username is required.")
                .Length(3, 50).WithMessage("The username must be between 3 and 50 characters.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
                .Matches(@"[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
                .Matches(@"[a-z]").WithMessage("Password must contain at least one lowercase letter.")
                .Matches(@"[0-9]").WithMessage("Password must contain at least one number.")
                .Matches(@"[\W_]").WithMessage("Password must contain at least one special character.")
                .Must(p => !p.Contains(" ")).WithMessage("Password must not contain spaces.");

            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("The access role is required.");
        }
    }
}
