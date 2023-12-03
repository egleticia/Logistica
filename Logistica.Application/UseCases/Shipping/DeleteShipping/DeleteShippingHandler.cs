using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Shipping.DeleteShipping
{
    public class DeleteShippingHandler : IRequestHandler<DeleteShippingRequest, DeleteShippingResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public DeleteShippingHandler(IUnitOfWork unitOfWork, IShippingRepository shippingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<DeleteShippingResponse> Handle(DeleteShippingRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var shipping = await _shippingRepository.Get(request.Id, cancellationToken);

                if (shipping == null) { throw new ArgumentException("Shipping not found"); }

                _shippingRepository.Delete(shipping);
                await _unitOfWork.Commit(cancellationToken);

                return _mapper.Map<DeleteShippingResponse>(shipping);

            }
            catch (Exception) { throw; }
        }
    }
}

