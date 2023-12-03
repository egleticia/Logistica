using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Receiver.GetReceiverById
{
    public class GetReceiverByIdHandler : IRequestHandler<GetReceiverByIdRequest, GetReceiverByIdResponse>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly IMapper _mapper;

        public GetReceiverByIdHandler(IReceiverRepository receiverRepository, IMapper mapper)
        {
            _receiverRepository = receiverRepository;
            _mapper = mapper;
        }

        public async Task<GetReceiverByIdResponse> Handle(GetReceiverByIdRequest request, CancellationToken cancellationToken)
        {
            var receiver = await _receiverRepository.Get(request.Id, cancellationToken);
            return _mapper.Map<GetReceiverByIdResponse>(receiver);
        }
    }
}

