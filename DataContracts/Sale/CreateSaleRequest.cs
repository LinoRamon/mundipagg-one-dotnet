using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts {

    /// <summary>
    /// Criação de uma nova venda
    /// </summary>
    [DataContract(Name = "CreateSaleRequest", Namespace = "")]
    public class CreateSaleRequest : BaseRequest {

        public CreateSaleRequest() {
            Options = new SaleOptions();
        }

        /// <summary>
        /// Lista de transações de cartão de crédito
        /// </summary>
        [DataMember]
        public Collection<CreditCardTransaction> CreditCardTransactionCollection { get; set; }

        /// <summary>
        /// Lista de transações de boleto
        /// </summary>
        [DataMember]
        public Collection<BoletoTransaction> BoletoTransactionCollection { get; set; }

        /// <summary>
        /// Dados do pedido
        /// </summary>
        [DataMember]
        public Order Order { get; set; }

        /// <summary>
        /// Dados do comprador
        /// </summary>
        [DataMember]
        public Buyer Buyer { get; set; }

        /// <summary>
        /// Lista de carrinhos de compra
        /// </summary>
        [DataMember]
        public Collection<ShoppingCart> ShoppingCartCollection { get; set; }

        /// <summary>
        /// Informações opcionais para a criação da venda
        /// </summary>
        [DataMember]
        public SaleOptions Options { get; set; }

        /// <summary>
        /// Dados da loja
        /// </summary>
        [DataMember]
        public Merchant Merchant { get; set; }

        /// <summary>
        /// Informações complementares da requisição
        /// </summary>
        [DataMember]
        public RequestData RequestData { get; set; }
    }
}