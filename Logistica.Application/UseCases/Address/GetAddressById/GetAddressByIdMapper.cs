
using AutoMapper;

namespace Logistica.Application.UseCases.Address.GetAddressById
{
    public sealed class GetAddressByIdMapper : Profile
    {
        public GetAddressByIdMapper()
        {
            CreateMap<Domain.Entities.Address, GetAddressByIdResponse>();
        }

    }
}
