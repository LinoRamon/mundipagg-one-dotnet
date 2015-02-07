using GatewayApiClient.ResourceClients.Interfaces;

namespace GatewayApiClient {

    /// <summary>
    /// Cliente para acesso aos serviços do gateway.
    /// </summary>
    public interface IGatewayServiceClient {

        /// <summary>
        /// Recurso de venda
        /// </summary>
        ISaleResource Sale { get; }
    }
}
