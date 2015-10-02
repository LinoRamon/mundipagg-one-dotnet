using System;
using System.Runtime.Serialization;
using GatewayApiClient.Notification.Contracts.Enum;

namespace GatewayApiClient.Notification.Contracts {

    [DataContract(Namespace = "")]
    public class CreditCardTransaction {

        [DataMember]
        public string Acquirer { get; set; }

        [DataMember]
        public long AmountInCents { get; set; }

        [DataMember]
        public string AuthorizationCode { get; set; }

        [DataMember(Name = "AuthorizedAmountInCents")]
        private string AuthorizedAmountInCentsField {
            get {
                if (this.AuthorizedAmountInCents == null) { return null; }
                return this.AuthorizedAmountInCents.ToString();
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    this.AuthorizedAmountInCents = null;
                }
                else {
                    this.AuthorizedAmountInCents = (long)long.Parse(value);
                }
            }
        }

        [IgnoreDataMember]
        public Nullable<long> AuthorizedAmountInCents { get; set; }

        [DataMember(Name = "CapturedAmountInCents")]
        private string CapturedAmountInCentsField {
            get {
                if (this.CapturedAmountInCents == null) { return null; }
                return this.CapturedAmountInCents.ToString();
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    this.CapturedAmountInCents = null;
                }
                else {
                    this.CapturedAmountInCents = (long)long.Parse(value);
                }
            }
        }

        [IgnoreDataMember]
        public Nullable<long> CapturedAmountInCents { get; set; }

        [DataMember]
        public string CreditCardBrand { get; set; }

        [DataMember]
        public string CustomStatus { get; set; }

        [DataMember(Name = "RefundedAmountInCents")]
        private string RefundedAmountInCentsField {
            get {
                if (this.RefundedAmountInCents == null) {
                    return null;
                }
                return this.RefundedAmountInCents.ToString();
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    this.RefundedAmountInCents = null;
                }
                else {
                    this.RefundedAmountInCents = (long)long.Parse(value);
                }
            }
        }

        [IgnoreDataMember]
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

        [DataMember(Name = "VoidedAmountInCents")]
        private string VoidedAmountInCentsField {
            get {
                if (this.VoidedAmountInCents == null) { return null; }
                return this.VoidedAmountInCents.ToString();
            }
            set {
                if (string.IsNullOrEmpty(value)) {
                    this.VoidedAmountInCents = null;
                }
                else {
                    this.VoidedAmountInCents = (long)long.Parse(value);
                }
            }
        }

        [IgnoreDataMember]
        public Nullable<long> VoidedAmountInCents { get; set; }

        [DataMember(Name = "PreviousCreditCardTransactionStatus")]
        private string PreviousCreditCardTransactionStatusField
        {
            get { return this.PreviousCreditCardTransactionStatus.ToString(); }
            set
            {
                this.PreviousCreditCardTransactionStatus =
                    (CreditCardTransactionStatusEnum) System.Enum.Parse(typeof (CreditCardTransactionStatusEnum), value);
            }
        }

        [IgnoreDataMember]
        public CreditCardTransactionStatusEnum PreviousCreditCardTransactionStatus { get; set; }

        [DataMember(Name = "CreditCardTransactionStatus")]
        private string CreditCardTransactionStatusField
        {
            get { return this.CreditCardTransactionStatus.ToString(); }
            set
            {
                this.CreditCardTransactionStatus =
                    (CreditCardTransactionStatusEnum) System.Enum.Parse(typeof (CreditCardTransactionStatusEnum), value);
            }
        }

        [IgnoreDataMember]
        public CreditCardTransactionStatusEnum CreditCardTransactionStatus { get; set; }
    }
}
