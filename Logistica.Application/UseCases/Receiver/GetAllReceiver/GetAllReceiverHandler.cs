using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Receiver.GetAllReceiver
{
    public class GetAllReceiverHandler : IRequestHandler<GetAllReceiverRequest, List<GetAllReceiverResponse>>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly IMapper _mapper;

        public GetAllReceiverHandler(IReceiverRepository receiverRepository, IMapper mapper)
        {
            _receiverRepository = receiverRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllReceiverResponse>> Handle(GetAllReceiverRequest request, CancellationToken cancellationToken)
        {
            var receiver = await _receiverRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllReceiverResponse>>(receiver);
        }
    }
}

