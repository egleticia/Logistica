using MediatR;


namespace Logistica.Application.UseCases.Product.UpdateProduct
{
    public sealed record UpdateProductRequest(Guid Id, Domain.Entities.Receiver Receiver, double ProductPrice, int Quantity) : IRequest<UpdateProductResponse>;
}
