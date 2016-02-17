using GatewayApiClient.DataContracts;
using GatewayApiClient.Utility;
using System;
using GatewayApiClient.DataContracts.InstantBuy;

namespace GatewayApiClient.ResourceClients.Interfaces {

    public interface ICreditCardResource : IBaseResource {

        HttpResponse<GetInstantBuyDataResponse> GetInstantBuyData(Guid instantBuyKey);

        HttpResponse<GetInstantBuyDataResponse> GetInstantBuyDataWithBuyerKey(Guid buyerKey);

        HttpResponse<GetInstantBuyDataResponse> GetCreditCard(Guid instantBuyKey);

        HttpResponse<GetInstantBuyDataResponse> GetCreditCardWithBuyerKey(Guid buyerKey);

        HttpResponse<CreateInstantBuyDataResponse> CreateCreditCard(
            CreateInstantBuyDataRequest createInstantBuyDataRequest);

        HttpResponse<DeleteInstantBuyDataResponse> DeleteCreditCard(Guid instantBuyKey);
    }
}
