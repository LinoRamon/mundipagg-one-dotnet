using GatewayApiClient.DataContracts.EnumTypes;
using System;
using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts.OnlineDebitTransaction {
    [DataContract(Name = "OnlineDebitTransaction", Namespace = "")]
    public class OnlineDebitTransaction {
        public Nullable<BankEnum> Bank { get; set; }
        private string _bankField;
        [DataMember(Name = "Bank")]
        private string BankField {
            get {
                return this._bankField;
            }
            set {
                this._bankField = value;
                if (value == null) {
                    this.Bank = null;
                }
                else {
                    BankEnum bankEnum;
                    if (Enum.TryParse<BankEnum>(value, true, out bankEnum)) {
                        this.Bank = bankEnum;
                    }

                }
            }
        }
        [DataMember]
        public long AmountInCents { get; set; }
        [DataMember]
        public OnlineDebitTransactionOptions Options { get; set; }
    }
}
