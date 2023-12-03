using AutoMapper;

namespace Logistica.Application.UseCases.Shipping.GetShippingById
{
    public class GetShippingByIdMapper : Profile
    {
        public GetShippingByIdMapper()
        {
            CreateMap<Domain.Entities.Shipping, GetShippingByIdResponse>();
        }
    }
}
