
using FluentValidation;

namespace Logistica.Application.UseCases.Receiver
{
    public sealed class CreateReceiverValidator : AbstractValidator<CreateReceiverRequest>
    {
        public CreateReceiverValidator()
        {
            RuleFor(x => x.Adress).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3);
        }
    }
}
