using FluentValidation;

namespace Logistica.Application.UseCases.Product.CreateProduct
{
    public sealed class CreateProductValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Receiver).NotEmpty();
            RuleFor(x => x.ProductPrice).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Quantity).NotNull().GreaterThan(0);
        }
    }
}
