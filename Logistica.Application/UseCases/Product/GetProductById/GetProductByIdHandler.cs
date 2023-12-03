using FluentValidation;


namespace Logistica.Application.UseCases.Product.GetProductById
{
    public class GetProductByIdHandler : AbstractValidator<GetProductByIdRequest>
    {
        public GetProductByIdHandler()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
