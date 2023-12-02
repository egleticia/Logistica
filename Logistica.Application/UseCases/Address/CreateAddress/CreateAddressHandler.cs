using AutoMapper;
using MediatR;
using Logistica.Domain.Interfaces;

namespace Logistica.Application.UseCases.Address.CreateAddress
{
    public class CreateAddressHandler : IRequestHandler<CreateAddressRequest, CreateAddressResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public CreateAddressHandler(IUnitOfWork unitOfWork, IAddressRepository addressRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<CreateAddressResponse> Handle(CreateAddressRequest request, CancellationToken cancellationToken)
        {
            var address = _mapper.Map<Domain.Entities.Address>(request);

            _addressRepository.Create(address);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateAddressResponse>(address);
        }
    }
}
