using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    /// <summary>
    /// Dados adicionais da requisição
    /// </summary>
    [DataContract(Name = "TokenRequestData", Namespace = "")]
    public class TokenRequestData {

        /// <summary>
        /// Coleção de dados genéricos
        /// </summary>
        [DataMember]
        public Collection<GenericData> GenericDataCollection { get; set; }

    }
}
