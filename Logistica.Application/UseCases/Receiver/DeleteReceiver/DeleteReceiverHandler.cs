
using AutoMapper;
using Logistica.Application.UseCases.Product.DeleteProduct;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.Receiver.DeleteReceiver
{
    public class DeleteReceiverHandler : IRequestHandler<DeleteReceiverRequest, DeleteReceiverResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReceiverRepository _receiverRepository;
        private readonly IMapper _mapper;

        public DeleteReceiverHandler(IUnitOfWork unitOfWork, IReceiverRepository receiverRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _receiverRepository = receiverRepository;
            _mapper = mapper;
        }

        public async Task<DeleteReceiverResponse> Handle(DeleteReceiverRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var receiver = await _receiverRepository.Get(request.Id, cancellationToken);

                if (receiver == null) { throw new ArgumentException("Receiver not found"); }

                _receiverRepository.Delete(receiver);
                await _unitOfWork.Commit(cancellationToken);

                return _mapper.Map<DeleteReceiverResponse>(receiver);

            }
            catch (Exception) { throw; }
        }
    }
}
