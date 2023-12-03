using MediatR;

namespace Logistica.Application.UseCases.Shipping.DeleteShipping
{
    public sealed record DeleteShippingRequest(Guid Id) : IRequest<DeleteShippingResponse>;
}
