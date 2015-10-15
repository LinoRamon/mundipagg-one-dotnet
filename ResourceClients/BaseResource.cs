using System;
using GatewayApiClient.ResourceClients.Interfaces;
using GatewayApiClient.Utility;

namespace GatewayApiClient.ResourceClients {

    public abstract class BaseResource : IBaseResource {

        private string _resourceName;
        public string ResourceName { get { return _resourceName; } }

        public Guid MerchantKey { get; set; }

        private string _hostUri;
        protected string HostUri { get { return _hostUri; } }

        internal HttpUtility HttpUtility { get; set; }

        protected BaseResource(Guid merchantKey, string resourceName)
            : this(merchantKey, resourceName, null) { }

        protected BaseResource(Guid merchantKey, string resourceName, Uri hostUri) {

            if (merchantKey == Guid.Empty) {
                merchantKey = ConfigurationUtility.GetConfigurationKey("MerchantKey");
            }

            this.HttpUtility = new HttpUtility();
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            this.MerchantKey = merchantKey;
            if (hostUri != null) {
                this._hostUri = hostUri.ToString();
                this._hostUri = this._hostUri.Remove(this._hostUri.Length - 1);
            }
            else {
                this._hostUri = this.GetServiceUri();
            }
            this._resourceName = resourceName;
        }

        private string GetServiceUri() {

            return ConfigurationUtility.GetConfigurationString("HostUri");
        }
    }
}
