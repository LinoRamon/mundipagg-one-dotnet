using System;
using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts {

    [DataContract(Namespace = "")]
    public class CreateBuyerResponse : BaseResponse {

        [DataMember]
        public Guid BuyerKey { get; set; }

        [DataMember]
        public bool Success { get; set; }
    }
}
