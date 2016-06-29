using GatewayApiClient.DataContracts.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    [DataContract(Name = "TokenInstallmentPlan", Namespace = "")]
    public class TokenInstallmentPlan {

        [DataMember(Name = "CreditCardBrand")]
        public string CreditCardBrandField {
            get {
                return this.CreditCardBrand.ToString();
            }
            set {
                this.CreditCardBrand = (CreditCardBrandEnum)Enum.Parse(typeof(CreditCardBrandEnum), value);
            }
        }

        /// <summary>
        /// Bandeira do cartão
        /// </summary>
        [IgnoreDataMember]
        public CreditCardBrandEnum CreditCardBrand { get; set; }

        /// <summary>
        /// Plano de parcelas para a bandeira
        /// </summary>
        [DataMember]
        public IEnumerable<TokenCreditCardInstallmentPlan> CreditCardInstallmentPlan { get; set; }

    }
}
