using FluentValidation;

namespace Logistica.Application.UseCases.Product.DeleteProduct
{
    public sealed class DeleteProductValidator : AbstractValidator<DeleteProductRequest>
    {
        public DeleteProductValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
