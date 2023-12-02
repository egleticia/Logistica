using AutoMapper;

namespace Logistica.Application.UseCases.PurchaseNotification.CreatePurchaseNotification
{
    public class CreatePurchaseNotificationMapper : Profile
    {
        public CreatePurchaseNotificationMapper()
        {
            CreateMap<CreatePurchaseNotificationRequest, Domain.Entities.PurchaseNotification>();
            CreateMap<Domain.Entities.PurchaseNotification, CreatePurchaseNotificationResponse>();
        }
    }
}
