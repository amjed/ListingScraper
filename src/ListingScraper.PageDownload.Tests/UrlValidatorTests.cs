using ListingScraper.Common.Exceptions;
using ListingScraper.Common.Messages;
using ListingScraper.PageDownload.Validation;
using Xunit;

namespace ListingScraper.PageDownload.Tests
{
    public class UrlValidatorTests
    {
        private readonly UrlValidator _sut;

        public UrlValidatorTests()
        {
            _sut = new UrlValidator();
        }

        [Theory]
        [InlineData("")]
        [InlineData("http:///w.test.1")]
        [InlineData("test.com")]
        [InlineData("12345678.net")]
        [InlineData("ftp://http")]
        [InlineData("ftp://www.google.com")]
        public void Validation_fails_if_url_is_invalid(string url)
        {
            var exception = Assert.Throws<UrlValidationException>(
                () => _sut.Validate(url));

            Assert.Equal(exception.Message,
                string.Format(ValidationMessages.IncorrectUrl, url));
        }

        [Theory]
        [InlineData("http://www.google.com")]
        [InlineData("https://www.stackoverflow.net")]
        public void Validation_pass_if_url_is_correct(string url)
        {
            _sut.Validate(url);
        }
    }
}
