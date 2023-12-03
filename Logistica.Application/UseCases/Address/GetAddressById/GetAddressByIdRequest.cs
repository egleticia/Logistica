using MediatR;

namespace Logistica.Application.UseCases.Address.GetAddressById
{
    public sealed record GetAddressByIdRequest(Guid Id) :
                   IRequest<GetAddressByIdResponse>;
}
