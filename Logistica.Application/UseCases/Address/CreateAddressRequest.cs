using Logistica.Domain.Enums;
using MediatR;

namespace Logistica.Application.UseCases.Address
{
    public sealed record CreateAddressRequest(string Street, string Number, string PostalCode, string City, 
        string State, string Country, string AddressLine2, string UnitNumber, string Landmark, Region Region) 
        : IRequest<CreateAddressResponse>;
}
