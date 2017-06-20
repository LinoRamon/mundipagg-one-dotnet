using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts.OnlineDebitTransaction {
    [DataContract(Name = "OnlineDebitTransactionOptions", Namespace = "")]
    public class OnlineDebitTransactionOptions {
        /// <summary>
        /// Define se o pagamento será realizado com dinheiro físico(SafetyPay).
        /// </summary>
        [DataMember]
        public bool IsCashTransaction { get; set; }

        /// <summary>
        /// Url para notificação da transação
        /// </summary>
        [DataMember]
        public string NotificationUrl { get; set; }
    }
}
