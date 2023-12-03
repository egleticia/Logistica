using MediatR;

namespace Logistica.Application.UseCases.Product.GetAllProduct
{
    public sealed record GetAllAProductRequest : IRequest<List<GetAllProductResponse>>;
}
