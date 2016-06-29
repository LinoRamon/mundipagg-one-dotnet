using GatewayApiClient.ResourceClients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GatewayApiClient.DataContracts;
using GatewayApiClient.DataContracts.Token;
using GatewayApiClient.Utility;
using System.Collections.Specialized;

namespace GatewayApiClient.ResourceClients {

    public class TokenResource : BaseResource, ITokenResource {

        public TokenResource(Guid merchantKey, Uri hostUri, NameValueCollection customHeaders) : base(merchantKey, "/Token", hostUri, customHeaders) { }

        /// <summary>
        /// Cria um token a partir de uma requisição completa
        /// </summary>
        /// <param name="createSaleRequest">Dados da venda</param>
        /// <returns></returns>
        public HttpResponse<TokenResponse> Create(TokenRequest tokenRequest) {
            NameValueCollection headers = this.GetHeaders();
            headers.Add("MerchantKey", this.MerchantKey.ToString());

            //Envia requisição
            return this.HttpUtility.SubmitRequest<TokenRequest, TokenResponse>(tokenRequest,
                string.Concat(this.HostUri, this.ResourceName), HttpVerbEnum.Post, EnumTypes.HttpContentTypeEnum.Json, headers);

        }

    }
}
