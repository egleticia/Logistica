using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Shipping.UpdateShipping
{
    public class UpdateShippingHandler : IRequestHandler<UpdateShippingRequest, UpdateShippingResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public UpdateShippingHandler(IUnitOfWork unitOfWork, IShippingRepository shippingRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }
        public async Task<UpdateShippingResponse> Handle(UpdateShippingRequest command, CancellationToken cancellationToken)
        {
            var shipping = await _shippingRepository.Get(command.Id, cancellationToken);

            if (shipping is null) return default;

            shipping.Address = command.Address;
            shipping.Receiver = command.Receiver;
            shipping.ApplyShippingPrice = command.ApplyShippingPrice;
            shipping.Price = command.Price;
            shipping.Status = command.Status;

            _shippingRepository.Update(shipping);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateShippingResponse>(shipping);
        }
    }
}
