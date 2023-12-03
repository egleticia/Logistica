using MediatR;


namespace Logistica.Application.UseCases.PurchaseNotification.GetPurchaseNotificationById
{
    public sealed record GetPurchaseNotificationByIdRequest(Guid Id) :
                   IRequest<GetPurchaseNotificationByIdResponse>;
}
