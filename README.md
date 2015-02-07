MundiPaggV2 .NET Integration library.
====================

.NET library for integration with MundiPagg payment web services.


## Usage

Put your merchant key and the target service host URI in your configuration file (web.config or app.config) under the keys _GatewayService.MerchantKey_ and _GatewayService.ProductionHostUri_.

App.config example: 
```xml
  <appSettings>
    <add key="GatewayService.MerchantKey" value="00000000-0000-0000-0000-000000000000"/>
    <add key="GatewayService.ProductionHostUri" value="https://transactionv2.mundipaggone.com"/>
  </appSettings>
```


## License

See the LICENSE file.
