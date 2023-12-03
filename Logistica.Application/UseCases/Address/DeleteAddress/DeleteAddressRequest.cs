using MediatR;

namespace Logistica.Application.UseCases.Address.DeleteAddress
{
    public sealed record DeleteAddressRequest(Guid Id) : IRequest<DeleteAddressResponse>;
}
