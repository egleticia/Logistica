using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Product.UpdateProduct
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductRequest, UpdateProductResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductHandler(IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<UpdateProductResponse> Handle(UpdateProductRequest command, CancellationToken cancellationToken)
        {
            var product = await _productRepository.Get(command.Id, cancellationToken);

            if (product is null) return default;

            product.Receiver = command.Receiver;
            product.ProductPrice = command.ProductPrice;
            product.Quantity = command.Quantity;


            _productRepository.Update(product);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateProductResponse>(product);
        }
    }
}
