using FluentValidation;

namespace PocketMoney.Application.Models.Users.Commands
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().NotEmpty().MaximumLength(50);
            RuleFor(x => x.Password).NotEmpty().MaximumLength(20);
        }
    }
}