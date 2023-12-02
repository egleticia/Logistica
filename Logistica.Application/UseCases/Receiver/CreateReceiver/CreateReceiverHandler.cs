
using AutoMapper;
using Logistica.Domain.Entities;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Receiver.CreateReceiver
{
    public class CreateReceiverHandler : IRequestHandler<CreateReceiverRequest, CreateReceiverResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReceiverRepository _receiverRepository;
        private readonly IMapper _mapper;

        public CreateReceiverHandler(IUnitOfWork unitOfWork, IReceiverRepository receiverRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _receiverRepository = receiverRepository;
            _mapper = mapper;
        }

        public async Task<CreateReceiverResponse> Handle(CreateReceiverRequest request, CancellationToken cancellationToken)
        {
            var receiver = _mapper.Map<Domain.Entities.Receiver>(request);

            _receiverRepository.Create(receiver);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateReceiverResponse>(receiver);
        }


    }
}
