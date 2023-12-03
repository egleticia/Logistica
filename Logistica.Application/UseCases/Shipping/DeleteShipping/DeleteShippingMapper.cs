using AutoMapper;

namespace Logistica.Application.UseCases.Shipping.DeleteShipping
{
    public class DeleteShippingMapper : Profile
    {
        public DeleteShippingMapper()
        {
            CreateMap<DeleteShippingRequest, Domain.Entities.Shipping>();
            CreateMap<Domain.Entities.Shipping, DeleteShippingResponse>();
        }
    }
}
