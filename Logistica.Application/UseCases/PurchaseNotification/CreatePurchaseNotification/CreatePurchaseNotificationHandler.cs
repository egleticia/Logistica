
using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;

namespace Logistica.Application.UseCases.PurchaseNotification.CreatePurchaseNotification
{
    public class CreatePurchaseNotificationHandler : IRequestHandler<CreatePurchaseNotificationRequest, CreatePurchaseNotificationResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPurchaseNotificationRepository _purchaseNotificationRepository;
        private readonly IMapper _mapper;

        public CreatePurchaseNotificationHandler(IUnitOfWork unitOfWork, IPurchaseNotificationRepository purchaseNotification, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _purchaseNotificationRepository = purchaseNotification;
            _mapper = mapper;
        }

        public async Task<CreatePurchaseNotificationResponse> Handle(CreatePurchaseNotificationRequest request, CancellationToken cancellationToken)
        {
            var purchaseNotificatin = _mapper.Map<Domain.Entities.PurchaseNotification>(request);

            _purchaseNotificationRepository.Create(purchaseNotificatin);

            _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreatePurchaseNotificationResponse>(purchaseNotificatin);
        }
    }
}
