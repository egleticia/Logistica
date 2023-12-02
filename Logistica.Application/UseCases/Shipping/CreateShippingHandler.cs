
using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Shipping
{
    public class CreateShippingHandler : IRequestHandler<CreateShippingRequest, CreateShippingResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public CreateShippingHandler(IUnitOfWork unitOfWork, IShippingRepository shippingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<CreateShippingResponse> Handle(CreateShippingRequest request, CancellationToken cancellationToken)
        {
            var shipping = _mapper.Map<Domain.Entities.Shipping>(request);

            _shippingRepository.Create(shipping);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateShippingResponse>(shipping);
        }
    }
}
