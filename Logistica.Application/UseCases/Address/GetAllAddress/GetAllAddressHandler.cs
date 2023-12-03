using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Address.GetAllAddress
{
    public sealed class GetAllAddressHandler : IRequestHandler<GetAllAddressRequest, List<GetAllAddressResponse>>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAllAddressHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllAddressResponse>> Handle(GetAllAddressRequest request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllAddressResponse>>(address);
        }
    }
}
