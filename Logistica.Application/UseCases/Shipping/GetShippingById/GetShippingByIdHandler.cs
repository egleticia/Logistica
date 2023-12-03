using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Shipping.GetShippingById
{
    public class GetShippingByIdHandler : IRequestHandler<GetShippingByIdRequest, GetShippingByIdResponse>
    {
        private readonly IShippingRepository _shippingRepository;
        private readonly IMapper _mapper;

        public GetShippingByIdHandler(IShippingRepository shippingRepository, IMapper mapper)
        {
            _shippingRepository = shippingRepository;
            _mapper = mapper;
        }

        public async Task<GetShippingByIdResponse> Handle(GetShippingByIdRequest request, CancellationToken cancellationToken)
        {
            var shipping = await _shippingRepository.Get(request.Id, cancellationToken);
            return _mapper.Map<GetShippingByIdResponse>(shipping);
        }
    }
}
