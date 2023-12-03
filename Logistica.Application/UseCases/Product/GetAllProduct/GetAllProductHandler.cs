using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Product.GetAllProduct
{
    public class GetAllProductHandler : IRequestHandler<GetAllAProductRequest, List<GetAllProductResponse>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetAllProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllProductResponse>> Handle(GetAllAProductRequest request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllProductResponse>>(product);
        }
    }
}
