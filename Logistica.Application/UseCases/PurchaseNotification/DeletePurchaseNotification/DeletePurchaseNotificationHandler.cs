
using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.PurchaseNotification.DeletePurchaseNotification
{
    public class DeletePurchaseNotificationHandler : IRequestHandler<DeletePurchaseNotificationRequest, DeletePurchaseNotificationResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPurchaseNotificationRepository _purchaseNotificationRepository;
        private readonly IMapper _mapper;

        public DeletePurchaseNotificationHandler(IUnitOfWork unitOfWork, IPurchaseNotificationRepository purchaseNotificationRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _purchaseNotificationRepository = purchaseNotificationRepository;
            _mapper = mapper;
        }

        public async Task<DeletePurchaseNotificationResponse> Handle(DeletePurchaseNotificationRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var purchaseNotification =  await _purchaseNotificationRepository.Get(request.Id, cancellationToken);

                if (purchaseNotification == null) { throw new ArgumentException("Purchase Notification not found"); }

                _purchaseNotificationRepository.Delete(purchaseNotification);
                await _unitOfWork.Commit(cancellationToken);

                return _mapper.Map<DeletePurchaseNotificationResponse>(purchaseNotification);

            }
            catch (Exception) { throw; }
        }
    }
}

