using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    /// <summary>
    /// Contrato de criação para os dados do pedido no Token
    /// </summary>
    [DataContract(Name = "TokenOrder", Namespace = "")]
    public class TokenOrder {

        /// <summary>
        /// Número da ordem no sistema da loja
        /// </summary>
        [DataMember]
        public string OrderReference { get; set; }

        /// <summary>
        /// Total em centavos
        /// </summary>
        [DataMember]
        public long AmountInCents { get; set; }

        /// <summary>
        /// Id da sessão do usuário no momento da compra
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Endereço IP da estação do comprador no momento da compra
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// URL de retorno de sucesso de processamento
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string CheckoutReturnUrl { get; set; }

        /// <summary>
        /// URL de notificação
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// URL de redirecionamento para abandono do checkout
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string CheckoutAbandonUrl { get; set; }

        /// <summary>
        /// Tempo de expiração do token a partir da criação
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public Nullable<long> ExpirationTimeInMinutes { get; set; }

    }
}
