
using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Address.GetAddressById
{
    public class GetAddressByIdHandler : IRequestHandler<GetAddressByIdRequest, GetAddressByIdResponse>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAddressByIdHandler(IAddressRepository adressesRepository, IMapper mapper)
        {
            _addressRepository = adressesRepository;
            _mapper = mapper;
        }

        public async Task<GetAddressByIdResponse> Handle(GetAddressByIdRequest request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.Get(request.Id, cancellationToken);
            return _mapper.Map<GetAddressByIdResponse>(address);
        }
    }
}
