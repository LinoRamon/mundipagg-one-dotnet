using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    /// <summary>
    /// Contrato de criação de um Token
    /// </summary>
    public class TokenRequest {

        /// <summary>
        /// <see cref="Order"/>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TokenOrder Order { get; set; }

        /// <summary>
        /// <see cref="Options"/>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TokenOptions Options { get; set; }

        /// <summary>
        /// <see cref="Buyer"/>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Buyer Buyer { get; set; }

        /// <summary>
        /// <see cref="ShoppingCart"/>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ShoppingCart ShoppingCart { get; set; }

        /// <summary>
        /// <see cref="TokenCreditCardRequest"/>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TokenCreditCard CreditCard { get; set; }

        /// <summary>
        /// <see cref="Boleto"/>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TokenBoleto Boleto { get; set; }

        /// <summary>
        /// <see cref="RequestData"/>
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TokenRequestData RequestData { get; set; }

    }
}
