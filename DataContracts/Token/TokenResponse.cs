using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    /// <summary>
    /// Contrato de resposta do Token
    /// </summary>
    [DataContract(Name = "TokenResponse", Namespace = "")]
    public class TokenResponse {

        #region TokenKey
        /// <summary>
        /// Chave do Token
        /// </summary>
        [DataMember(Name = "TokenKey")]
        private string TokenKeyField {
            get {
                //Verifica se a chave de token não é nula
                if (this.TokenKey != null) {
                    //Retorna a chave de token
                    return this.TokenKey.ToString();
                }
                else {
                    return null;
                }
            }
            set {
                //Tenta efetuar o parse:
                Guid token;
                if (Guid.TryParse(value, out token) == true) {
                    this.TokenKey = token;
                }
            }

        }

        /// <summary>
        /// Chave do Token
        /// </summary>
        [IgnoreDataMember]
        public Nullable<Guid> TokenKey { get; set; }
        #endregion

        /// <summary>
        /// Identificação da sessão do usuário
        /// </summary>
        [DataMember]
        public string SessionId { get; set; }

        /// <summary>
        /// Url para pagamento do pedido criado
        /// </summary>
        [DataMember]
        public string PaymentURL { get; set; }

        /// <summary>
        /// Indica se houve sucesso no processamento
        /// </summary>
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public ErrorReport ErrorReport { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Guid MerchantKey { get; set; }

        [DataMember]
        public Guid RequestKey { get; set; }

        [DataMember]
        public Nullable<long> InternalTime { get; set; }

    }
}
