using System;
using ListingScraper.Common.Exceptions;
using ListingScraper.Common.Messages;

namespace ListingScraper.PageDownload.Validation
{
    public class UrlValidator : IUrlValidator
    {
        public void Validate(string url)
        {
            var isValid = Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                          && (uriResult.Scheme == Uri.UriSchemeHttp
                              || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!isValid)
            {
                throw new UrlValidationException(
                    string.Format(ValidationMessages.IncorrectUrl, url));
            }
        }
    }
}