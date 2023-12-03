using MediatR;

namespace Logistica.Application.UseCases.Product.DeleteProduct
{
    public sealed record DeleteProductRequest(Guid Id) : IRequest<DeleteProductResponse>;
}
