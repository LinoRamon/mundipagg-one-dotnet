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

        public GatewayServiceClient(Guid merchantKey) : this(merchantKey, PlatformEnvironment.Production, HttpContentTypeEnum.Json, null) { }

        public GatewayServiceClient(Guid merchantKey, Uri hostUri) : this(merchantKey, PlatformEnvironment.Production, HttpContentTypeEnum.Json, hostUri) { }

        public GatewayServiceClient() : this(Guid.Empty, PlatformEnvironment.Production) { }

        public GatewayServiceClient(Guid merchantKey, PlatformEnvironment environment) : this(merchantKey, environment, HttpContentTypeEnum.Json, null) { }

        public GatewayServiceClient(Guid merchantKey, PlatformEnvironment environment, HttpContentTypeEnum httpContentType) : this(merchantKey, environment, httpContentType, null) { }

        public GatewayServiceClient(Guid merchantKey, PlatformEnvironment environment, HttpContentTypeEnum httpContentType, Uri hostUri) {

            this._sale = new SaleResource(merchantKey, environment, httpContentType, hostUri);
            this._creditCard = new CreditCardResource(merchantKey, environment, httpContentType, hostUri);
        }
    }
}
