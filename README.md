MundiPaggV2 .NET Integration library.
====================

.NET library for integration with MundiPagg payment web services.

## NuGet
  PM> Install-Package MundiPagg.Gateway.Client

## Getting started

```c#
// Creates the credit card.
CreditCard creditCard = new CreditCard();
creditCard.CreditCardNumber = "4111111111111111";
creditCard.CreditCardBrand = CreditCardBrandEnum.Visa;
creditCard.ExpMonth = 10;
creditCard.ExpYear = 2018;
creditCard.SecurityCode = "123";
creditCard.HolderName = "Somebody";

// Create the transaction.
CreateSaleRequest createSaleRequest = new CreateSaleRequest();
createSaleRequest.CreditCardTransactionCollection = new Collection<CreditCardTransaction>();
createSaleRequest.CreditCardTransactionCollection.Add(new CreditCardTransaction() {
    AmountInCents = 100,
    CreditCard = creditCard,
    Options = new CreditCardTransactionOptions() { PaymentMethodCode = 1 } // Simulator
});

try {

    Guid merchantKey = Guid.Parse("00000000-0000-0000-0000-000000000000"); // Put your MerchantKey here.
    Uri endpoint = new Uri("https://stagingv2.mundipaggone.com");

    // Creates the client that will send the transaction.
    IGatewayServiceClient serviceClient = new GatewayServiceClient(merchantKey, PlatformEnvironment.Sandbox, HttpContentTypeEnum.Json, endpoint);

    // Authorizes the credit card transaction and returns the gateway response.
    HttpResponse<CreateSaleResponse> httpResponse = serviceClient.Sale.Create(createSaleRequest);

    // API response code
    Console.WriteLine("Status: {0}", httpResponse.HttpStatusCode);

    CreateSaleResponse createSaleResponse = httpResponse.Response;
    if (httpResponse.HttpStatusCode == HttpStatusCode.Created) {
        foreach (var creditCardTransaction in createSaleResponse.CreditCardTransactionResultCollection) {
            Console.WriteLine(creditCardTransaction.AcquirerMessage);
        }
    }
    else {
        if (createSaleResponse.ErrorReport != null) {
            foreach (ErrorItem errorItem in createSaleResponse.ErrorReport.ErrorItemCollection) {
                Console.WriteLine("Error {0}: {1}", errorItem.ErrorCode, errorItem.Description);
            }
        }
    }
}
catch (Exception ex) {
    Console.WriteLine(ex.Message);
}

Console.ReadKey();
            
```

## Simulator rules by amount

### Authorization

* `<= $ 1.050,00 -> Authorized`
* `>= $ 1.050,01 && < $ 1.051,71 -> Timeout`
* `>= $ 1.500,00 -> Not Authorized`
 
### Capture

* `<= $ 1.050,00 -> Captured`
* `>= $ 1.050,01 -> Not Captured`
 
### Cancellation

* `<= $ 1.050,00 -> Cancelled`
* `>= $ 1.050,01 -> Not Cancelled`
 
### Refund
* `<= $ 1.050,00 -> Refunded`
* `>= $ 1.050,01 -> Not Refunded`

## Documentation

  http://docs.mundipagg.com
  
## Other examples

* [Capture](https://github.com/mundipagg/mundipagg-one-dotnet/wiki/Capture-method)
* [Cancel](https://github.com/mundipagg/mundipagg-one-dotnet/wiki/Cancel-method)

## License

See the LICENSE file.
