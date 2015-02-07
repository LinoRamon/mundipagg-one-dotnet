using System;
using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts {

    [DataContract(Namespace = "")]
    public abstract class BaseRequest {

        /// <summary>
        /// Chave da requisição. Utilizada para identificar uma requisição específica no gateway.
        /// </summary>
        [DataMember]
        public virtual Guid RequestKey { get; set; }
    }
}