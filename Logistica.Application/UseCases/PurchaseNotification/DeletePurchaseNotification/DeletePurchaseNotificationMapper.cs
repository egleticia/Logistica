using AutoMapper;

namespace Logistica.Application.UseCases.PurchaseNotification.DeletePurchaseNotification
{
    public class DeletePurchaseNotificationMapper : Profile
    {
        public DeletePurchaseNotificationMapper()
        {
            CreateMap<DeletePurchaseNotificationRequest, Domain.Entities.PurchaseNotification>();
            CreateMap<Domain.Entities.PurchaseNotification, DeletePurchaseNotificationResponse>();
        }
    }
}
