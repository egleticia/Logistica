using FluentValidation;

namespace Logistica.Application.UseCases.Shipping
{
    public class CreateShippingValidator : AbstractValidator<CreateShippingRequest>
    {
        public CreateShippingValidator()
        {
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.Receiver).NotEmpty();
            RuleFor(x => x.ApplyShippingPrice).NotEmpty();
            RuleFor(x => x.Price).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Status).NotEmpty().IsInEnum();
        }
    }
}
