using AutoMapper;

namespace Logistica.Application.UseCases.Address.GetAllAddress
{
    public class GetAllAddressMapper : Profile
    {
        public GetAllAddressMapper()
        {
            CreateMap<Domain.Entities.Address, GetAllAddressResponse>();
        }
    }
}
