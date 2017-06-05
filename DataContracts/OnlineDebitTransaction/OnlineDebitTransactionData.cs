using System;
using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts.OnlineDebitTransaction {
    [DataContract(Name = "OnlineDebitTransactionData", Namespace = "")]
    public class OnlineDebitTransactionData {
        [DataMember]
        public long AmountInCents { get; internal set; }
        [DataMember]
        public long? AmountPaidInCents { get; internal set; }
        [DataMember]
        public string BankName { get; internal set; }
        [DataMember]
        public string BankReturnCode { get; internal set; }
        [DataMember]
        public string BankReturnMessage { get; internal set; }

        /// <summary>
        /// Data de criação
        /// </summary>
        [DataMember(Name = "CreateDate")]
        private string CreateDateField {
            get {
                return this.CreateDate.ToString(ServiceConstants.DATE_TIME_FORMAT);
            }
            set {
                this.CreateDate = DateTime.ParseExact(value, ServiceConstants.DATE_TIME_FORMAT, null);
            }
        }

        [IgnoreDataMember]
        public DateTime CreateDate { get; set; }

        [DataMember]
        public string OnlineDebitTransactionStatus { get; internal set; }
        [DataMember]
        public Guid TransactionKey { get; internal set; }
        [DataMember]
        public string TransactionKeyToBank { get; internal set; }
    }
}
