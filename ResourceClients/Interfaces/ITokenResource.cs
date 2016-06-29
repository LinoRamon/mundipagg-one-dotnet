using GatewayApiClient.DataContracts;
using GatewayApiClient.DataContracts.Token;
using GatewayApiClient.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GatewayApiClient.ResourceClients.Interfaces {
    public interface ITokenResource {

        /// <summary>
        /// Cria uma token a partir de uma requisição completa
        /// </summary>
        /// <param name="createSaleRequest">Dados da venda</param>
        /// <returns></returns>
        HttpResponse<TokenResponse> Create(TokenRequest tokenRequest);       

    }
}
