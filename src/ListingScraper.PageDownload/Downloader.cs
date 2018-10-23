using System.Collections.Generic;
using System.Net;
using ListingScraper.PageDownload.Validation;
using System.Net.Http;
using System.Threading.Tasks;
using ListingScraper.Common.Exceptions;
using ListingScraper.Common.Messages;


namespace ListingScraper.PageDownload
{
    public class Downloader : IDownloader
    {
        private readonly IUrlValidator _urlValidator;
        private readonly HttpClient _httpClient;

        public Downloader(IUrlValidator urlValidator, HttpClient httpClient)
        {
            _urlValidator = urlValidator;
            _httpClient = httpClient;
        }

        public async Task<string> Download(string url)
        {
            _urlValidator.Validate(url);

            var response = await _httpClient.GetAsync(url);

            var acceptableStatusCodes =
                new List<HttpStatusCode> { HttpStatusCode.Accepted, HttpStatusCode.OK };

            if (!acceptableStatusCodes.Contains(response.StatusCode))
            {
                throw new DownloadException(
                    string.Format(ValidationMessages.DownloadFailed, url, response.StatusCode));
            }

            var content = await response.Content.ReadAsStringAsync();

            return content;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
