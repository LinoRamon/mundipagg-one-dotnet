using System.Net;

namespace GatewayApiClient.Utility {

    /// <summary>
    /// Resposta do gateway
    /// </summary>
    public class HttpResponse {

        /// <summary>
        /// Mensagem serializada recebida do gateway. (XML ou JSON)
        /// </summary>
        public string RawResponse { get; private set; }

        /// <summary>
        /// Código HTTP retornado pelo gateway.
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; private set; }

        public HttpResponse(string rawResponse, HttpStatusCode httpStatusCode) {

            this.RawResponse = rawResponse;
            this.HttpStatusCode = httpStatusCode;
        }
    }

    /// <summary>
    /// Resposta do gateway
    /// </summary>
    /// <typeparam name="TResponse">Tipo de resposta</typeparam>
    public class HttpResponse<TResponse> : HttpResponse {

        /// <summary>
        /// Objeto que representa a resposta do gateway.
        /// </summary>
        public TResponse Response { get; private set; }

        public HttpResponse(TResponse response, string rawResponse, HttpStatusCode httpStatusCode)
            : base(rawResponse, httpStatusCode) {

            this.Response = response;
        }
    }

    /// <summary>
    /// Resposta do gateway
    /// </summary>
    /// <typeparam name="TResponse">Tipo de resposta</typeparam>
    /// <typeparam name="TRequest">Tipo de requisição</typeparam>
    public class HttpResponse<TResponse, TRequest> : HttpResponse<TResponse> {

        /// <summary>
        /// Objeto que representa a requisição enviada para o gateway
        /// </summary>
        public TRequest Request { get; private set; }

        /// <summary>
        /// Mensagem serializada enviada para o gateway. (XML ou JSON)
        /// </summary>
        public string RawRequest { get; private set; }

        public HttpResponse(TRequest request, string rawRequest, TResponse response, string rawResponse, HttpStatusCode httpStatusCode)
            : base(response, rawResponse, httpStatusCode) {

            this.Request = request;
            this.RawRequest = rawRequest;
        }
    }
}
