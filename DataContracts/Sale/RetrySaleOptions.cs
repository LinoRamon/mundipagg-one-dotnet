using System;
using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts {

    [DataContract(Name = "RetrySaleOptions", Namespace = "")]
    public class RetrySaleOptions {

        /// <summary>
        /// Indica se o limite extendido está habilitado
        /// </summary>
        [DataMember]
        public Nullable<bool> ExtendedLimitEnabled { get; set; }

        /// <summary>
        /// Código do limite extendido
        /// </summary>
        [DataMember]
        public string ExtendedLimitCode { get; set; }
    }
}
