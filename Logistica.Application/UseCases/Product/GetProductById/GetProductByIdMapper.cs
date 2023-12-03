using AutoMapper;

namespace Logistica.Application.UseCases.Product.GetProductById
{
    public class GetProductByIdMapper : Profile
    {
        public GetProductByIdMapper()
        {
            CreateMap<Domain.Entities.Product, GetProductByIdResponse>();
        }
    }
}
