using System;
using System.IO;
using System.Net;
using GatewayApiClient.TransactionReportFile;
using GatewayApiClient.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GatewayApiClient.Tests.TransactionReportFile {

    [TestClass]
    public class TransactionReportParserTests : BaseTests {
        #region HostUri
        private readonly Uri _hostUri = new Uri("https://apisandbox.mundipaggone.com:8443/");
        #endregion

        [TestMethod]
        public void ItShouldDownloadTransactionReportFile() {
            // Cria o client que enviará a transação
            TransactionReportClient transactionReportClient = new TransactionReportClient(MerchantKey, _hostUri);

            // Faz o download para a variável
            HttpResponse httpResponse = transactionReportClient.DownloadReport(new DateTime(2015, 9, 19));

            Assert.AreEqual(HttpStatusCode.OK, httpResponse.HttpStatusCode);
        }

        [TestMethod]
        public void ItShouldParseTransactionReportFile() {
            // Cria o client que enviará a transação
            TransactionReportClient transactionReportClient = new TransactionReportClient(MerchantKey, _hostUri);

            // Faz o download para a variável
            HttpResponse httpResponse = transactionReportClient.DownloadReport(new DateTime(2015, 9, 15));

            Assert.AreEqual(HttpStatusCode.OK, httpResponse.HttpStatusCode);

            TransactionReportParser transactionReportParser = new TransactionReportParser();

            var response = transactionReportParser.ParseString(httpResponse.RawResponse);

            Assert.AreEqual(response.Header.ReportFileCreateDate, new DateTime(2015, 9, 16));
        }

        [TestMethod]
        public void ItShouldDownloadAndParseTransactionReport() {
            // Cria o client que enviará a transação
            TransactionReportClient transactionReportClient = new TransactionReportClient(MerchantKey, _hostUri);

            // Gera um arquivo temporário na máquina
            string tempFile = Path.GetTempFileName();

            // Faz o download para a variável
            HttpStatusCode httpResponse = transactionReportClient.DownloadReportToFile(new DateTime(2015, 9, 15), tempFile);


            Assert.AreEqual(HttpStatusCode.OK, httpResponse);

            TransactionReportParser transactionReportParser = new TransactionReportParser();

            // Faz o parse do arquivo temporário
            var response = transactionReportParser.ParseFile(tempFile);

            Assert.AreEqual(response.Header.ReportFileCreateDate, new DateTime(2015, 9, 16));

            // Deleta o arquivo temporário na máquina
            File.Delete(tempFile);
        }

        [TestMethod]
        public void ItShouldDownloadAndSaveTransactionReportFile() {
            // Cria o client que enviará a transação
            TransactionReportClient transactionReportClient = new TransactionReportClient(MerchantKey, _hostUri);

            // Generate temporary file
            string tempFile = Path.GetTempFileName();

            // Faz o download para a variável
            HttpStatusCode httpResponse = transactionReportClient.DownloadReportToFile(new DateTime(2015, 9, 19), tempFile);

            Assert.AreEqual(HttpStatusCode.OK, httpResponse);

            File.Delete(tempFile);
        }
    }
}
