using MediatR;

namespace Logistica.Application.UseCases.Shipping.GetAllShipping
{
    public sealed record GetAllShippingRequest : IRequest<List<GetAllShippingResponse>>;
}
