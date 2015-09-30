using System;
using System.Runtime.Serialization;
using GatewayApiClient.Notification.Contracts.Enum;

namespace GatewayApiClient.Notification.Contracts {

    //[DataContract(Name = "BoletoTransaction")]
    public class BoletoTransaction {

        [DataMember]
        public BoletoTransactionStatusEnum PreviousBoletoTransactionStatus { get; set; }

        [DataMember]
        public BoletoTransactionStatusEnum BoletoTransactionStatus { get; set; }

        [DataMember]
        public DateTime StatusChangedDate { get; set; }

        [DataMember]
        public Guid TransactionKey { get; set; }

        [DataMember]
        public string TransactionReference { get; set; }

        [DataMember]
        public DateTime BoletoExpirationDate { get; set; }

        [DataMember]
        public string NossoNumero { get; set; }

        [DataMember]
        public long AmountInCents { get; set; }

        [DataMember]
        public long AmountPaidInCents { get; set; }
    }
}
