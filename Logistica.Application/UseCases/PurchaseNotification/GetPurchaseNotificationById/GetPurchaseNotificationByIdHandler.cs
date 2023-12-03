using AutoMapper;
using Logistica.Domain.Interfaces;
using MediatR;


namespace Logistica.Application.UseCases.PurchaseNotification.GetPurchaseNotificationById
{
    public class GetPurchaseNotificationByIdHandler : IRequestHandler<GetPurchaseNotificationByIdRequest, GetPurchaseNotificationByIdResponse>
    {
        private readonly IPurchaseNotificationRepository _purchaseNotificationRepository;
        private readonly IMapper _mapper;

        public GetPurchaseNotificationByIdHandler(IPurchaseNotificationRepository purchaseNotificationRepository, IMapper mapper)
        {
            _purchaseNotificationRepository = purchaseNotificationRepository;
            _mapper = mapper;
        }

        public async Task<GetPurchaseNotificationByIdResponse> Handle(GetPurchaseNotificationByIdRequest request, CancellationToken cancellationToken)
        {
            var purchaseNotification = await _purchaseNotificationRepository.Get(request.Id, cancellationToken);
            return _mapper.Map<GetPurchaseNotificationByIdResponse>(purchaseNotification);
        }
    }
}
