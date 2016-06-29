using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.Token {

    [DataContract(Name = "TokenCreditCardInstallmentPlan ", Namespace = "")]
    public class TokenCreditCardInstallmentPlan {

        /// <summary>
        /// Valor mínimo para habilitar o intervalo de parcelamento
        /// </summary>
        [DataMember]
        public long OrderAmountInCentsMin { get; set; }

        /// <summary>
        /// Número mínimo de parcelas
        /// </summary>
        [DataMember]
        public long InstallmentMin { get; set; }

        /// <summary>
        /// Número máximo de parcelas
        /// </summary>
        [DataMember]
        public long InstallmentMax { get; set; }

    }
}
