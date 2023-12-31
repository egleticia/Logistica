﻿

namespace Logistica.Application.UseCases.PurchaseNotification.GetAllPurchaseNotification
{
    public sealed record GetAllPurchaseNotificationResponse
    {
        public Guid ShippingId { get; set; }
        public Domain.Entities.Receiver Receiver { get; set; }
        public Domain.Entities.Product Product { get; set; }
    }
}
