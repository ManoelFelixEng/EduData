using FluentValidation;
using EduData.Domain.Entities;

namespace EduData.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name) 
                .NotEmpty().WithMessage("O nome de usuário é obrigatório.")
                .Length(3, 50).WithMessage("O usuário deve ter entre 3 e 50 caracteres.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(6).WithMessage("A senha deve ter pelo menos 6 caracteres.");

            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("O perfil de acesso (Role) é obrigatório.");
        }
    }
}