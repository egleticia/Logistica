using MediatR;
using AutoMapper;
using Logistica.Domain.Interfaces;

namespace Logistica.Application.UseCases.Address.DeleteAddress
{
    public class DeleteAddressHandler : IRequestHandler<DeleteAddressRequest, DeleteAddressResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public DeleteAddressHandler(IUnitOfWork unitOfWork, IAddressRepository addressRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<DeleteAddressResponse> Handle(DeleteAddressRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var address = await _addressRepository.Get(request.Id, cancellationToken);

                if (address == null) { throw new ArgumentException("Address not found"); }

                _addressRepository.Delete(address);
                await _unitOfWork.Commit(cancellationToken);

                return _mapper.Map<DeleteAddressResponse>(address);

            }
            catch (Exception) { throw; }
        }

    }
}
