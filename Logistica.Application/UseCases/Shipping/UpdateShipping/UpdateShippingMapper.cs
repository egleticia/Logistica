using AutoMapper;

namespace Logistica.Application.UseCases.Shipping.UpdateShipping
{
    public class UpdateShippingMapper : Profile
    {
        public UpdateShippingMapper()
        {
            CreateMap<UpdateShippingRequest, Domain.Entities.Shipping>();
            CreateMap<Domain.Entities.Shipping, UpdateShippingResponse>();
        }
    }
}
