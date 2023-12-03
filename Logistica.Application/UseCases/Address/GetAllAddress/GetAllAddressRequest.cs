using MediatR;

namespace Logistica.Application.UseCases.Address.GetAllAddress
{
    public sealed record GetAllAddressRequest : IRequest<List<GetAllAddressResponse>>;

}
