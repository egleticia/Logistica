using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Receiver.UpdateReceiver
{
    public class UpdateReceiverHandler : IRequestHandler<UpdateReceiverRequest, UpdateReceiverResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReceiverRepository _receiverRepository;
        private readonly IMapper _mapper;

        public UpdateReceiverHandler(IUnitOfWork unitOfWork, IReceiverRepository receiverRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _receiverRepository = receiverRepository;
            _mapper = mapper;
        }
        public async Task<UpdateReceiverResponse> Handle(UpdateReceiverRequest command, CancellationToken cancellationToken)
        {
            var receiver = await _receiverRepository.Get(command.Id, cancellationToken);

            if (receiver is null) return default;

            receiver.Address = command.Adress;
            receiver.Name = command.Name;

            _receiverRepository.Update(receiver);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateReceiverResponse>(receiver);
        }
    }
}
