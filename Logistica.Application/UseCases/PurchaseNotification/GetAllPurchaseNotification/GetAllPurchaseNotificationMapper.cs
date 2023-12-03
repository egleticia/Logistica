using AutoMapper;

namespace Logistica.Application.UseCases.PurchaseNotification.GetAllPurchaseNotification
{
    public class GetAllPurchaseNotificationMapper : Profile
    {
        public GetAllPurchaseNotificationMapper()
        {
            CreateMap<Domain.Entities.PurchaseNotification, GetAllPurchaseNotificationResponse>();
        }
    }
}
