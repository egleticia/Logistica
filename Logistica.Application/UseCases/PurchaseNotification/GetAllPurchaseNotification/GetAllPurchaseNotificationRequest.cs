using MediatR;

namespace Logistica.Application.UseCases.PurchaseNotification.GetAllPurchaseNotification
{
    public sealed record GetAllPurchaseNotificationRequest : IRequest<List<GetAllPurchaseNotificationResponse>>;
}
