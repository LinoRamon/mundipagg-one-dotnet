using System;
using System.Runtime.Serialization;
using GatewayApiClient.Notification.Contracts.Enum;

namespace GatewayApiClient.Notification.Contracts {

    [DataContract]
    public class CreditCardTransaction {

        [DataMember]
        public string Acquirer { get; set; }

        [DataMember]
        public long AmountInCents { get; set; }

        [DataMember]
        public string AuthorizationCode { get; set; }

        [DataMember]
        public long? AuthorizedAmountInCents { get; set; }

        [DataMember]
        public Nullable<long> CapturedAmountInCents { get; set; }

        [DataMember]
        public string CreditCardBrand { get; set; }

        [DataMember]
        public string CustomStatus { get; set; }

        [DataMember]
        public Nullable<long> RefundedAmountInCents { get; set; }

        [DataMember]
        public DateTime StatusChangedDate { get; set; }

        [DataMember]
        public string TransactionIdentifier { get; set; }

        [DataMember]
        public Guid TransactionKey { get; set; }

        [DataMember]
        public string TransactionReference { get; set; }

        [DataMember]
        public string UniqueSequentialNumber { get; set; }

        [DataMember]
        public Nullable<long> VoidedAmountInCents { get; set; }

        [DataMember]
        public CreditCardTransactionStatusEnum PreviousCreditCardTransactionStatus { get; set; }

        [DataMember]
        public CreditCardTransactionStatusEnum CreditCardTransactionStatus { get; set; }
    }
}
