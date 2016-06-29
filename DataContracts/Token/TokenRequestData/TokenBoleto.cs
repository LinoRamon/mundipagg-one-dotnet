using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    /// <summary>
    /// Dados para a requisição de criação de um Boleto Bancário
    /// </summary>
    [DataContract(Name = "TokenBoleto", Namespace = "")]
    public class TokenBoleto {

        /// <summary>
        /// Texto do campo "Instruções" do boleto
        /// </summary>
        [DataMember]
        public string Instructions { get; set; }

        /// <summary>
        /// Número do boleto
        /// </summary>
        [DataMember]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Número de dias para adicionar à data atual para definir o vencimento do boleto
        /// </summary>
        [DataMember]
        public int DaysToAddInBoletoExpirationDate { get; set; }

        /// <summary>
        /// Número do banco
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string BankNumber { get; set; }

    }
}
