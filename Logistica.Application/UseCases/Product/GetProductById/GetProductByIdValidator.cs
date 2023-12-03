using FluentValidation;

namespace Logistica.Application.UseCases.Product.GetProductById
{
    public sealed class GetProductByIdValidator : AbstractValidator<GetProductByIdRequest>
    {
        public GetProductByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
