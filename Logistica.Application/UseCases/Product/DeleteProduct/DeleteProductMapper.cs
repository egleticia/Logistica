using AutoMapper;

namespace Logistica.Application.UseCases.Product.DeleteProduct
{
    public sealed class DeleteProductMapper : Profile
    {
        public DeleteProductMapper()
        {
            CreateMap<DeleteProductRequest, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, DeleteProductResponse>();
        }
    }
}
