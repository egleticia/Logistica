using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;


namespace Logistica.Application.UseCases.PurchaseNotification.GetAllPurchaseNotification
{
    public class GetAllPurchaseNotificationHandler : IRequestHandler<GetAllPurchaseNotificationRequest, List<GetAllPurchaseNotificationResponse>>
    {
        private readonly IPurchaseNotificationRepository _purchaseNotificationRepository;
        private readonly IMapper _mapper;

        public GetAllPurchaseNotificationHandler(IPurchaseNotificationRepository purchaseNotificationRepository, IMapper mapper)
        {
            _purchaseNotificationRepository = purchaseNotificationRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllPurchaseNotificationResponse>> Handle(GetAllPurchaseNotificationRequest request, CancellationToken cancellationToken)
        {
            var purchaseNotifications = await _purchaseNotificationRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllPurchaseNotificationResponse>>(purchaseNotifications);
        }
    }
}

