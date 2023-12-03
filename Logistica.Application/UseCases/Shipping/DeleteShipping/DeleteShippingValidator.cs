using FluentValidation;

namespace Logistica.Application.UseCases.Shipping.DeleteShipping
{
    public sealed class DeleteShippingValidator : AbstractValidator<DeleteShippingRequest>
    {
        public DeleteShippingValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
