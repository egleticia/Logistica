using AutoMapper;

namespace Logistica.Application.UseCases.Address.DeleteAddress
{
    public sealed class DeleteAddressMapper : Profile
    {
        public DeleteAddressMapper()
        {
            CreateMap<DeleteAddressRequest, Domain.Entities.Address>();
            CreateMap<Domain.Entities.Address, DeleteAddressResponse>();
        }
    }
}
