using Logistica.Application.UseCases.Address.GetAddressById;
using MediatR;


namespace Logistica.Application.UseCases.Product.GetProductById
{
    public sealed record GetProductByIdRequest(Guid Id) : IRequest<GetProductByIdResponse>;
}