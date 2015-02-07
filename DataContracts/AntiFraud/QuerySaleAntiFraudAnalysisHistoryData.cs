using System;
using System.Runtime.Serialization;
using GatewayApiClient.DataContracts.EnumTypes;

namespace GatewayApiClient.DataContracts {

    /// <summary>
    /// Histórico de antifraude
    /// </summary>
    [DataContract(Name = "QuerySaleAntiFraudAnalysisHistory", Namespace = "")]
    public class QuerySaleAntiFraudAnalysisHistoryData {

        #region AntiFraudAnalysisStatus

        /// <summary>
        /// Status do antifraude
        /// </summary>
        [DataMember(Name = "AntiFraudAnalysisStatus")]
        private string AntiFraudAnalysisStatusField {
            get {
                if (this.AntiFraudAnalysisStatus == null) { return null; }
                return this.AntiFraudAnalysisStatus.ToString();
            }
            set {
                if (value == null) {
                    this.AntiFraudAnalysisStatus = null;
                }
                else {
                    this.AntiFraudAnalysisStatus = (AntiFraudAnalysisStatusEnum)Enum.Parse(typeof(AntiFraudAnalysisStatusEnum), value);
                }
            }
        }

        /// <summary>
        /// Status da análise do serviço de anti fraude
        /// </summary>
        public Nullable<AntiFraudAnalysisStatusEnum> AntiFraudAnalysisStatus { get; set; }

        #endregion

        /// <summary>
        /// Código de retorno do serviço de anti fraude
        /// </summary>
        [DataMember]
        public String ReturnCode { get; set; }

        /// <summary>
        /// Status de retorno
        /// </summary>
        [DataMember]
        public String ReturnStatus { get; set; }

        /// <summary>
        /// Menssagem de retorno
        /// </summary>
        [DataMember]
        public String ReturnMessage { get; set; }

        /// <summary>
        /// Pontuação
        /// </summary>
        [DataMember]
        public Nullable<decimal> Score { get; set; }
    }
}