using GatewayApiClient.DataContracts.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GatewayApiClient.DataContracts
{
    [DataContract(Name = "OnlineDebitTransaction", Namespace = "")]
    public class OnlineDebitTransaction
    {
        /// <summary>
        /// Valor da transação em centavos
        /// </summary>
        [DataMember]
        public long AmountInCents { get; set; }

        /// <summary>
        /// Banco do comprador
        /// </summary>
        [DataMember(Name = "Bank", EmitDefaultValue = false)]
        private string BankField
        {
            get
            {
                if (this.Bank == null) { return null; }
                return this.Bank.Value.ToString();
            }
            set
            {
                if (value == null)
                {
                    this.Bank = null;
                }
                else
                {
                    this.Bank = (BankEnum)Enum.Parse(typeof(BankEnum), value);
                }
            }
        }

        /// <summary>
        /// Bandeira do cartão de crédito
        /// </summary>
        public Nullable<BankEnum> Bank { get; set; }
    }
}
