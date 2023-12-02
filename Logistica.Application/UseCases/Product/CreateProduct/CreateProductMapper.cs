using AutoMapper;

namespace Logistica.Application.UseCases.Product.CreateProduct
{
    public class CreateProductMapper : Profile
    {
        public CreateProductMapper()
        {
            CreateMap<CreateProductRequest, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, CreateProductResponse>();
        }

    }
}
