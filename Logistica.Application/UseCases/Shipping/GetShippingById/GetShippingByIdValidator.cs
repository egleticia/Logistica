using FluentValidation;

namespace Logistica.Application.UseCases.Shipping.GetShippingById
{
    public sealed class GetShippingByIdValidator : AbstractValidator<GetShippingByIdRequest>
    {
        public GetShippingByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
