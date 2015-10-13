using GatewayApiClient.EnumTypes;
using GatewayApiClient.ResourceClients;
using GatewayApiClient.ResourceClients.Interfaces;
using System;

namespace GatewayApiClient {

    /// <summary>
    /// Cliente para acesso aos serviços do gateway.
    /// </summary>
    public class GatewayServiceClient : IGatewayServiceClient {

        #region Recursos utilizados na SDK

        private ISaleResource _sale;
        /// <summary>
        /// Recurso de venda
        /// </summary>
        public ISaleResource Sale { get { return _sale; } }

        private ICreditCardResource _creditCard;
        /// <summary>
        /// Recurso de cartão de crédito
        /// </summary>
        public ICreditCardResource CreditCard { get { return _creditCard; } }

        #endregion

        public GatewayServiceClient(Guid merchantKey) : this(merchantKey, null) { }

        public GatewayServiceClient(Guid merchantKey, Uri hostUri) {

            this._sale = new SaleResource(merchantKey, hostUri);
            this._creditCard = new CreditCardResource(merchantKey, hostUri);
        }
    }
}
