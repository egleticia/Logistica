
using Logistica.Application.UseCases.Address.CreateAddress;
using Logistica.Domain.Enums;
using MediatR;

namespace Logistica.Application.UseCases.Address.UpdateAddress
{
    public sealed record UpdateAddressRequest(Guid Id, string Street, string Number, string PostalCode, string City,
        string State, string Country, string AddressLine2, string UnitNumber, string Landmark, Region Region)
        : IRequest<UpdateAddressResponse>;
}
