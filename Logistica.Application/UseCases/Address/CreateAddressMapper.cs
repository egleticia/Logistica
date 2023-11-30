using AutoMapper;

namespace Logistica.Application.UseCases.Address
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
