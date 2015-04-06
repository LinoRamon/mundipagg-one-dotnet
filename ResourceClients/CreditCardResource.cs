using GatewayApiClient.DataContracts;
using GatewayApiClient.EnumTypes;
using GatewayApiClient.ResourceClients.Interfaces;
using GatewayApiClient.Utility;
using System;
using System.Collections.Specialized;

namespace GatewayApiClient.ResourceClients {

    public class CreditCardResource : BaseResource, ICreditCardResource {

        public CreditCardResource(Guid merchantKey, PlatformEnvironment platformEnvironment, HttpContentTypeEnum httpContentType) : base(merchantKey, platformEnvironment, httpContentType, "/CreditCard") { }
        public CreditCardResource(Guid merchantKey, PlatformEnvironment platformEnvironment, HttpContentTypeEnum httpContentType, Uri hostUri) : base(merchantKey, platformEnvironment, httpContentType, "/CreditCard", hostUri) { }

        public HttpResponse<GetInstantBuyDataResponse> GetInstantBuyData(Guid instantBuyKey) {
            return this.GetInstantBuyDataImplementation(instantBuyKey, string.Empty);
        }

        public HttpResponse<GetInstantBuyDataResponse> GetInstantBuyDataWithBuyerKey(Guid buyerKey) {
            return this.GetInstantBuyDataImplementation(buyerKey, "BuyerKey");
        }

        private HttpResponse<GetInstantBuyDataResponse> GetInstantBuyDataImplementation(Guid key, string identifierName) {

            if (string.IsNullOrWhiteSpace(identifierName) == false) { identifierName = string.Concat("/", identifierName); }

            string actionName = string.Format("/{0}{1}", key.ToString(), identifierName);

            HttpVerbEnum httpVerb = HttpVerbEnum.Get;

            NameValueCollection header = new NameValueCollection();
            header.Add("MerchantKey", this.MerchantKey.ToString());

            return this.HttpUtility.SubmitRequest<GetInstantBuyDataResponse>(string.Concat(this.HostUri, this.ResourceName, actionName), httpVerb, this.HttpContentType, header);
        }
    }
}
