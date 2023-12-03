using AutoMapper;

namespace Logistica.Application.UseCases.Shipping.GetAllShipping
{
    public class GetAllShippingMapper : Profile
    {
        public GetAllShippingMapper()
        {
            CreateMap<Domain.Entities.Shipping, GetAllShippingResponse>();
        }
    }
}
