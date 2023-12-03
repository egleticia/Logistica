using MediatR;

namespace Logistica.Application.UseCases.Shipping.GetShippingById
{
    public sealed record GetShippingByIdRequest(Guid Id) :
                   IRequest<GetShippingByIdResponse>;
}
