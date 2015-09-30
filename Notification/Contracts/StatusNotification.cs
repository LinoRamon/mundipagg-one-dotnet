using System;
using System.Runtime.Serialization;
using GatewayApiClient.Notification.Contracts.Enum;

namespace GatewayApiClient.Notification.Contracts {

    //[DataContract(Name = "StatusNotification", Namespace = "http://schemas.datacontract.org/2004/07/MundiPagg.NotificationService.DataContract")]
    [DataContract(Name = "StatusNotification", Namespace = "")]
    public class StatusNotification {

        [DataMember]
        public CreditCardTransaction CreditCardTransaction { get; set; }

        [DataMember]
        public BoletoTransaction BoletoTransaction { get; set; }

        [DataMember]
        public OnlineDebitTransaction OnlineDebitTransaction { get; set; }

        [DataMember]
        public Guid MerchantKey { get; set; }

        [DataMember]
        public string OrderReference { get; set; }

        [DataMember]
        public Guid OrderKey { get; set; }

        [DataMember]
        public long AmountInCents { get; set; }

        [DataMember]
        public long AmountPaidInCents { get; set; }

        [DataMember]
        public OrderStatusEnum OrderStatus { get; set; }
    }
}
