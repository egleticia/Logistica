using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Shipping.GetAllShipping
{
    public  class GetAllShippingHandler : IRequestHandler<GetAllShippingRequest, List<GetAllShippingResponse>>
    {
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public GetAllShippingHandler(IShippingRepository shippingRepository, IMapper mapper)
        {
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllShippingResponse>> Handle(GetAllShippingRequest request, CancellationToken cancellationToken)
        {
            var shipping = await _shippingRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllShippingResponse>>(shipping);
        }
    }
}
