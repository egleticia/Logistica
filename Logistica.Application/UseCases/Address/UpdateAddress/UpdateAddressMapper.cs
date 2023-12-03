using AutoMapper;

namespace Logistica.Application.UseCases.Address.UpdateAddress
{
    public sealed class UpdateAddressMapper : Profile
    {
        public UpdateAddressMapper()
        {
            CreateMap<UpdateAddressRequest, Domain.Entities.Address>();
            CreateMap<Domain.Entities.Address, UpdateAddressResponse>();
        }

    }
}
