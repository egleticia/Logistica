using AutoMapper;

namespace Logistica.Application.UseCases.Shipping.CreateShipping
{
    public class CreateShippingMapper : Profile
    {
        public CreateShippingMapper()
        {
            CreateMap<CreateShippingRequest, Domain.Entities.Shipping>();
            CreateMap<Domain.Entities.Shipping, CreateShippingResponse>();
        }

    }
}
