using System;
using System.Runtime.Serialization;
using GatewayApiClient.Notification.Contracts.Enum;

namespace GatewayApiClient.Notification.Contracts {

    [DataContract(Name = "OnlineDebitTransaction")]
    public class OnlineDebitTransaction {

        [DataMember]
        public OnlineDebitTransactionStatusEnum PreviousOnlineDebitTransactionStatus { get; set; }

        [DataMember]
        public OnlineDebitTransactionStatusEnum OnlineDebitTransactionStatus { get; set; }

        [DataMember]
        public DateTime StatusChangedDate { get; set; }

        [DataMember]
        public Guid TransactionKey { get; set; }

        [DataMember]
        public string TransactionReference { get; set; }

        [DataMember]
        public long AmountInCents { get; set; }

        [DataMember]
        public long AmountPaidInCents { get; set; }

        [DataMember]
        public string TransactionKeyToBank { get; set; }

        [DataMember]
        public string BankPaymentDate { get; set; }

        [DataMember]
        public string BankName { get; set; }
    }
}
