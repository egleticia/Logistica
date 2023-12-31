﻿namespace Logistica.Application.UseCases.PurchaseNotification.CreatePurchaseNotification
{
    public sealed record CreatePurchaseNotificationResponse
    {
        public Guid ShippingId { get; set; }
        public Domain.Entities.Receiver Receiver { get; set; }
        public Domain.Entities.Product Product { get; set; }
    }
}
