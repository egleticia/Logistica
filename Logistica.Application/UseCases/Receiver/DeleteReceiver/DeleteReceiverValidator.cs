using FluentValidation;

namespace Logistica.Application.UseCases.Receiver.DeleteReceiver
{
    public sealed class DeleteReceiverValidator : AbstractValidator<DeleteReceiverRequest>
    {
        public DeleteReceiverValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
