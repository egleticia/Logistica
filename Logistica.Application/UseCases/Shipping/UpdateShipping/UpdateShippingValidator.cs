using FluentValidation;

namespace Logistica.Application.UseCases.Shipping.UpdateShipping
{
    public sealed class UpdateShippingValidator : AbstractValidator<UpdateShippingRequest>
    {
        public UpdateShippingValidator()
        {
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.Receiver).NotEmpty();
            RuleFor(x => x.ApplyShippingPrice).NotEmpty();
            RuleFor(x => x.Price).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Status).NotEmpty().IsInEnum();
        }
    }
}
