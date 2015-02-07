using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts {

    /// <summary>
    /// Dados da loja
    /// </summary>
    [DataContract(Name = "Merchant", Namespace = "")]
    public class Merchant {

        /// <summary>
        /// Identificador da loja na plataforma
        /// </summary>
        [DataMember]
        public string MerchantReference { get; set; }
    }
}