using System;
using System.Runtime.Serialization;
using GatewayApiClient.DataContracts.EnumTypes;

namespace GatewayApiClient.DataContracts {

    /// <summary>
    /// Dados complementares da requisição
    /// </summary>
    [DataContract(Name = "RequestData", Namespace = "")]
    public class RequestData {

        /// <summary>
        /// Identificador da origen do venda na loja
        /// </summary>
        [DataMember]
        public string Origin { get; set; }

        /// <summary>
        /// Identificador da sessão do usuário no sistema da loja (utilizado pelo serviço de anti fraude)
        /// </summary>
        [DataMember]
        public string SessionId { get; set; }

        /// <summary>
        /// Endereço IP do cliente da loja
        /// </summary>
        [DataMember]
        public string IpAddress { get; set; }

        #region EcommerceCategory

        /// <summary>
        /// Categoria da venda e-commerce. B2B ou B2C
        /// </summary>
        [DataMember(Name = "EcommerceCategory")]
        private string EcommerceCategoryField {
            get {
                if (this.EcommerceCategory == null) { return null; }
                return this.EcommerceCategory.ToString();
            }
            set {
                if (value == null) {
                    this.EcommerceCategory = null;
                }
                else {
                    this.EcommerceCategory = (EcommerceCategoryEnum)Enum.Parse(typeof(EcommerceCategoryEnum), value);
                }
            }
        }

        /// <summary>
        /// Categoria da venda e-commerce. B2B ou B2C
        /// </summary>
        public Nullable<EcommerceCategoryEnum> EcommerceCategory { get; set; }

        #endregion
    }
}