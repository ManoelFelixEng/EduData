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
                
                    .Length(3, 50).WithMessage("The user must have between 3 and 50 characters.");

                RuleFor(x => x.Password)
                    .NotEmpty().WithMessage("A password is required.")
                    .MinimumLength(8).WithMessage("The password must be at least 8 characters long.");

                RuleFor(x => x.Role)
                    .NotEmpty().WithMessage("The access profile (Role) is required.");
            }
        }
    }