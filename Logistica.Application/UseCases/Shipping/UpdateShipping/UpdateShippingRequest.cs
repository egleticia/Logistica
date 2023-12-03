using MediatR;

namespace Logistica.Application.UseCases.Shipping.UpdateShipping
{
    public sealed record UpdateShippingRequest(Guid Id, Domain.Entities.Address Address, Domain.Entities.Receiver Receiver, bool ApplyShippingPrice, double Price, Domain.Enums.Status Status) : IRequest<UpdateShippingResponse>;
}
