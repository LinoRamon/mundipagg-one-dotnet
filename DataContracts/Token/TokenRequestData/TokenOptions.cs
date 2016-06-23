using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    /// <summary>
    /// Opções do pedido
    /// </summary>
    [DataContract(Name = "TokenOptions", Namespace = "")]
    public class TokenOptions {

        /// <summary>
        /// Indica se utilizará o antifraude
        /// </summary>
        [DataMember]
        public Nullable<bool> IsAntiFraudEnabled { get; set; }

        /// <summary>
        /// Indica se o pedido poderá ser processado com pagamento via cartão de crédito
        /// </summary>
        [DataMember]
        public Nullable<bool> IsCreditCardPaymentEnabled { get; set; }

        /// <summary>
        /// Indica se o pedido poderá ser processado com pagamento via boleto
        /// </summary>
        [DataMember]
        public Nullable<bool> IsBoletoPaymentEnabled { get; set; }

    }
}
