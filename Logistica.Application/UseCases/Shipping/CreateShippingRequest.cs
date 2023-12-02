using MediatR;

namespace Logistica.Application.UseCases.Shipping
{
    public sealed record CreateShippingRequest(Domain.Entities.Address Address, Domain.Entities.Receiver Receiver, bool ApplyShippingPrice, double Price, Domain.Enums.Status Status) : IRequest<CreateShippingResponse>;
}
