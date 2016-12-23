using GatewayApiClient.DataContracts.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts {

    [DataContract(Name = "BoletoTransactionResult", Namespace = "")]
    public class OnlineDebitTransactionResult {
        /// <summary>
        /// Valor da transação em centavos
        /// </summary>
        [DataMember]
        public long AmountInCents { get; set; }

        #region OnlineDebitTransactionStatus

        /// <summary>
        /// Status da transação
        /// </summary>
        [DataMember(Name = "OnlineDebitTransactionStatus")]
        private string OnlineDebitTransactionStatusField {
            get {                
                return this.OnlineDebitTransactionStatus.ToString();
            }
            set {                
                this.OnlineDebitTransactionStatus = (OnlineDebitTransactionStatusEnum)Enum.Parse(typeof(OnlineDebitTransactionStatusEnum), value);
            }
        }

        /// <summary>
        /// Status da Transação
        /// </summary>
        [IgnoreDataMember]
        public OnlineDebitTransactionStatusEnum OnlineDebitTransactionStatus { get; set; }

        #endregion

        /// <summary>
        /// Url para pagamento da transação
        /// </summary>
        [DataMember]
        public string PaymentUrl { get; set; }

        /// <summary>
        /// Indica se houve sucesso na criação da transação
        /// </summary>
        [DataMember]
        public bool Success { get; set; }


        /// <summary>
        /// Chave da transação. Utilizada para identificar a transação de Débito no gateway
        /// </summary>
        [DataMember]
        public Guid TransactionKey { get; set; }

        /// <summary>
        /// Identificador da transação junto ao banco
        /// </summary>
        [DataMember]
        public string TransactionKeyToBank { get; set; }
    }
}
