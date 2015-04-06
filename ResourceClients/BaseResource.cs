using System;
using System.Configuration;
using GatewayApiClient.EnumTypes;
using GatewayApiClient.ResourceClients.Interfaces;
using GatewayApiClient.Utility;

namespace GatewayApiClient.ResourceClients {

    public abstract class BaseResource : IBaseResource {

        private string _resourceName;
        public string ResourceName { get { return _resourceName; } }

        public Guid MerchantKey { get; set; }

        public PlatformEnvironment PlatformEnvironment { get; set; }

        protected HttpContentTypeEnum HttpContentType { get; private set; }

        private string _hostUri;
        protected string HostUri { get { return _hostUri; } }

        internal HttpUtility HttpUtility { get; set; }

        protected BaseResource(Guid merchantKey, PlatformEnvironment platformEnvironment, HttpContentTypeEnum httpContentType, string resourceName)
            : this(merchantKey, platformEnvironment, httpContentType, resourceName, null) { }

        protected BaseResource(Guid merchantKey, PlatformEnvironment platformEnvironment, HttpContentTypeEnum httpContentType, string resourceName, Uri hostUri) {

            if (merchantKey == Guid.Empty) {
                merchantKey = this.GetConfigurationKey("GatewayService.MerchantKey");
            }

            this.HttpUtility = new HttpUtility();
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            this.MerchantKey = merchantKey;
            this.PlatformEnvironment = platformEnvironment;
            this.HttpContentType = httpContentType;
            if (hostUri != null) {
                this._hostUri = hostUri.ToString();
                this._hostUri = this._hostUri.Remove(this._hostUri.Length - 1);
            }
            else {
                this._hostUri = this.GetServiceUri(platformEnvironment);
            }
            this._resourceName = resourceName;
        }

        private string GetServiceUri(PlatformEnvironment platformEnvironment) {

            switch (platformEnvironment) {
                case PlatformEnvironment.Production:
                    return this.GetConfigurationString("GatewayService.ProductionHostUri");
                case PlatformEnvironment.Sandbox:
                    return this.GetConfigurationString("GatewayService.SandboxHostUri");
                default:
                    return null;
            }
        }

        private string GetConfigurationString(string configurationName) {

            string configurationValue = ConfigurationManager.AppSettings["configurationName"];
            if (string.IsNullOrWhiteSpace(configurationValue)) { throw new ConfigurationErrorsException("Missing configuration: " + configurationName); }

            return configurationValue;
        }
        private Guid GetConfigurationKey(string configurationName) {

            string configurationValue = this.GetConfigurationString(configurationName);

            Guid key;
            if (Guid.TryParse(configurationValue, out key) == false) { throw new ConfigurationErrorsException("Invalid configuration format: " + configurationName); }

            return key;
        }
    }
}
