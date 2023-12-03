using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Address.UpdateAddress
{
    public class UpdateAddressHandler : IRequestHandler<UpdateAddressRequest, UpdateAddressResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public UpdateAddressHandler(IUnitOfWork unitOfWork,IAddressRepository addressRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<UpdateAddressResponse> Handle(UpdateAddressRequest command, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.Get(command.Id, cancellationToken);

            if (address is null) return default;

            address.Street = command.Street;
            address.Number = command.Number;
            address.PostalCode = command.PostalCode;
            address.City = command.City;
            address.State = command.State;
            address.Country = command.Country;
            address.AddressLine2 = command.AddressLine2;
            address.UnitNumber = command.UnitNumber;
            address.Landmark = command.Landmark;
            address.Region = command.Region;

            _addressRepository.Update(address);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateAddressResponse>(address);
        }
    }
}
