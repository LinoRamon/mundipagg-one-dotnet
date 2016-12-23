using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts.EnumTypes
{
    [DataContract]
    public enum OnlineDebitTransactionStatusEnum
    {
        /// <summary>
        /// Pendente de Pagamento
        /// </summary>
        [EnumMember]
        OpenedPendingPayment = 1,

        /// <summary>
        /// Pago
        /// </summary>
        [EnumMember]
        Paid = 2,

        /// <summary>
        /// Pago a menor
        /// </summary>
        [EnumMember]
        Underpaid = 3,

        /// <summary>
        /// Pago a maior
        /// </summary>
        [EnumMember]
        Overpaid = 4,

        /// <summary>
        /// Não pago
        /// </summary>
        [EnumMember]
        NotPaid = 5,

        /// <summary>
        /// Erro
        /// </summary>
        [EnumMember]
        WithError = 6,

    }
}
