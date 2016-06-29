using GatewayApiClient.DataContracts.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    [DataContract(Name = "TokenCreditCard", Namespace = "")]
    public class TokenCreditCard {

        /// <summary>
        /// Coleção de planos de parcelamento para cada bandeira
        /// </summary>
        [DataMember]
        public IEnumerable<TokenInstallmentPlan> InstallmentPlanCollection { get; set; }

        /// <summary>
        /// Meio de pagamento que deve ser usado para a transação de cartão de crédito
        /// </summary>
        [DataMember]
        public int PaymentMethodCode { get; set; }

        /// <summary>
        /// Texto da fatura do cartão
        /// </summary>
        [DataMember]
        public string SoftDescriptorText { get; set; }

        [DataMember(Name = "CreditCardOperation")]
        public string CreditCardOperationField {
            get {
                if (this.CreditCardOperation == null) return null;
                return this.CreditCardOperation.ToString();
            }
            set {
                this.CreditCardOperation = (CreditCardOperationEnum)Enum.Parse(typeof(CreditCardOperationEnum), value);
            }
        }

        /// <summary>
        /// Indica a operação de cartão de crédito (AuthOnly ou AuthAndCapture)
        /// </summary>
        [IgnoreDataMember]
        public Nullable<CreditCardOperationEnum> CreditCardOperation;

    }
}
