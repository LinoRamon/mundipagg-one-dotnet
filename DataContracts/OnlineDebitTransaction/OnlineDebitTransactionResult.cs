using System;
using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts.OnlineDebitTransaction {
    [DataContract(Name = "OnlineDebitTransactionResult", Namespace = "")]
    public class OnlineDebitTransactionResult {
        [DataMember]
        public string PaymentUrl { get; set; }
        [DataMember]
        public string OnlineDebitTransactionStatus { get; set; }
        [DataMember]
        public Guid TransactionKey { get; set; }
        [DataMember]
        public long AmountInCents { get; set; }
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public string TransactionKeyToBank { get; set; }
    }
}
