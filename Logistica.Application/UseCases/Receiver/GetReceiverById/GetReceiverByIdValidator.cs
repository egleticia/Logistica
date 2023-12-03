using FluentValidation;

namespace Logistica.Application.UseCases.Receiver.GetReceiverById
{
    public sealed class GetReceiverByIdValidator : AbstractValidator<GetReceiverByIdRequest>
    {
        public GetReceiverByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
