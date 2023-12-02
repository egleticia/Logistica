using AutoMapper;

namespace Logistica.Application.UseCases.Address.CreateAddress
{
    public class CreateAddressMapper : Profile
    {
        public CreateAddressMapper()
        {
            CreateMap<CreateAddressRequest, Domain.Entities.Address>();
            CreateMap<Domain.Entities.Address, CreateAddressResponse>();
        }

    }
}
