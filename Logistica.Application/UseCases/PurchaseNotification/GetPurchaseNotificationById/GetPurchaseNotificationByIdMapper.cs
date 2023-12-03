using AutoMapper;

namespace Logistica.Application.UseCases.PurchaseNotification.GetPurchaseNotificationById
{
    public class GetPurchaseNotificationByIdMapper : Profile
    {
        public GetPurchaseNotificationByIdMapper()
        {
            CreateMap<Domain.Entities.PurchaseNotification, GetPurchaseNotificationByIdResponse>();
        }
    }
}
