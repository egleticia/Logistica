using AutoMapper;
using MediatR;
using Logistica.Domain.Interfaces;

namespace Logistica.Application.UseCases.Message
{
    public class CreateMessageHandler
    {
        private readonly IKafkaProducer _kafkaRepository;
        private readonly IMapper _mapper;

        public CreateMessageHandler(IKafkaProducer kafkaRepository, IMapper mapper)
        {
            _kafkaRepository = kafkaRepository;
            _mapper = mapper;
        }

        public async Task<CreateMessageResponse> Handle(CreateMessageRequest request, CancellationToken cancellationToken)
        {
            var message = await _kafkaRepository.ProduceAsyncWithRetry(
                request.topic,
                request.sender,
                request.receiver,
                request.content);

            return _mapper.Map<CreateMessageResponse>(message);
        }
    }
}
