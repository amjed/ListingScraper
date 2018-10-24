using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using ListingScraper.Common.Exceptions;
using ListingScraper.Common.Messages;
using ListingScraper.PageDownload.Validation;
using Moq;
using Moq.Protected;
using Xunit;

namespace ListingScraper.PageDownload.Tests
{
    public class DownloaderTests
    {
        private readonly Downloader _sut;
        private readonly string _testHtmlContent;
        private readonly Mock<HttpMessageHandler> _mockMessageHandler;
        private static char DirectorySeperator = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)? '/' : '\\';

        public DownloaderTests()
        {
            var mockValidator = new Mock<IUrlValidator>();
            mockValidator
                .Setup(m => m.Validate(It.IsAny<string>()))
                .Verifiable();

            _testHtmlContent = File.ReadAllText($"TestData{DirectorySeperator}sample.html");
            _mockMessageHandler = new Mock<HttpMessageHandler>();
            _sut = new Downloader(mockValidator.Object, new HttpClient(_mockMessageHandler.Object));
        }

        [Fact]
        public void A_successful_download_is_not_empty()
        {
            SetupHttpResponse(_mockMessageHandler, HttpStatusCode.OK);

            var content = _sut.Download("http://www.test.com/")
                .GetAwaiter()
                .GetResult();

            Assert.NotEmpty(content);
            Assert.Equal(content, _testHtmlContent);
        }

        [Fact]
        public void A_failed_download_throws_download_exception()
        {
            SetupHttpResponse(_mockMessageHandler, HttpStatusCode.NotFound);
            var url = "http://www.test.com/";
            var exception = Assert.ThrowsAsync<DownloadException>(
                () => _sut.Download(url))
                .GetAwaiter()
                .GetResult();
                
            Assert.Equal(exception.Message, 
                string.Format(ValidationMessages.DownloadFailed, url, HttpStatusCode.NotFound));            
        }


        private void SetupHttpResponse(Mock<HttpMessageHandler> mockMessageHandler,
            HttpStatusCode statusCode)
        {
            mockMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = statusCode,
                    Content = new StringContent(_testHtmlContent)
                });
        }
    }
}
