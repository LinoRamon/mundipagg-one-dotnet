using System;
using System.Collections.Specialized;
using GatewayApiClient.DataContracts;
using GatewayApiClient.EnumTypes;
using GatewayApiClient.ResourceClients.Interfaces;
using GatewayApiClient.Utility;

namespace GatewayApiClient.ResourceClients {

    public class CreditCardResource : BaseResource, ICreditCardResource {

        public CreditCardResource(Guid merchantKey, Uri hostUri, NameValueCollection customHeaders) : base(merchantKey, "/CreditCard", hostUri, customHeaders) { }

        [Obsolete("GetInstantBuyData(Guid instantBuyKey) is deprecated, please use GetCreditCard(Guid instantBuyKey) instead.")]
        public HttpResponse<GetInstantBuyDataResponse> GetInstantBuyData(Guid instantBuyKey) {
            return this.GetCreditCard(instantBuyKey);
        }

        [Obsolete("GetInstantBuyDataWithBuyerKey(Guid buyerKey) is deprecated, please use GetCreditCardWithBuyerKey(Guid buyerKey) instead.")]
        public HttpResponse<GetInstantBuyDataResponse> GetInstantBuyDataWithBuyerKey(Guid buyerKey) {
            return this.GetCreditCardWithBuyerKey(buyerKey);
        }

        public HttpResponse<GetInstantBuyDataResponse> GetCreditCard(Guid instantBuyKey)
        {
            return this.GetInstantBuyDataImplementation(instantBuyKey, string.Empty);
        }

        public HttpResponse<GetInstantBuyDataResponse> GetCreditCardWithBuyerKey(Guid buyerKey)
        {
            return this.GetInstantBuyDataImplementation(buyerKey, "BuyerKey=");
        }

        private HttpResponse<GetInstantBuyDataResponse> GetInstantBuyDataImplementation(Guid key, string identifierName) {

            string actionName = string.Format("/{0}{1}", identifierName, key.ToString());

            HttpVerbEnum httpVerb = HttpVerbEnum.Get;

            NameValueCollection headers = this.GetHeaders();
            headers.Add("MerchantKey", this.MerchantKey.ToString());

            return this.HttpUtility.SubmitRequest<GetInstantBuyDataResponse>(string.Concat(this.HostUri, this.ResourceName, actionName), httpVerb, HttpContentTypeEnum.Json, headers);
        }
    }
}
