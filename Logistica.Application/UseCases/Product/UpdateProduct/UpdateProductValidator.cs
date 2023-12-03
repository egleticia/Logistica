
using FluentValidation;

namespace Logistica.Application.UseCases.Product.UpdateProduct
{
    public sealed class UpdateProductValidator : AbstractValidator<UpdateProductResponse>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Receiver).NotEmpty();
            RuleFor(x => x.ProductPrice).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Quantity).NotNull().GreaterThan(0);
        }
    }
}
