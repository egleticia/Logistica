using MediatR;

namespace Logistica.Application.UseCases.Product
{
    public sealed record CreateProductRequest(Domain.Entities.Receiver Receiver, double ProductPrice, int Quantity) : IRequest<CreateProductResponse>;
}
