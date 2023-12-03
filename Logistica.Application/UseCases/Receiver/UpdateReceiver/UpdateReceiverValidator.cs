using FluentValidation;

namespace Logistica.Application.UseCases.Receiver.UpdateReceiver
{
    public sealed class UpdateReceiverValidator : AbstractValidator<UpdateReceiverRequest>
    {
        public UpdateReceiverValidator()
        {
            RuleFor(x => x.Adress).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3);
        }
    }
}
