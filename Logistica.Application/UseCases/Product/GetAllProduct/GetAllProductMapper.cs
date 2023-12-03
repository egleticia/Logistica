using AutoMapper;

namespace Logistica.Application.UseCases.Product.GetAllProduct
{
    public class GetAllProductMapper : Profile
    {
        public GetAllProductMapper()
        {
            CreateMap<Domain.Entities.Product, GetAllProductResponse>();
        }
    }
}
