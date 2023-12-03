using AutoMapper;

namespace Logistica.Application.UseCases.Product.UpdateProduct
{
    public sealed class UpdateProductMapper : Profile
    {
        public UpdateProductMapper()
        {
            CreateMap<UpdateProductRequest, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, UpdateProductResponse>();
        }
    }
}
