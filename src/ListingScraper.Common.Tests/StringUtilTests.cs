using System.IO;
using ListingScraper.Common.Utilities;
using Xunit;

namespace ListingScraper.Common.Tests
{
    public class StringUtilTests
    {
        private readonly StringUtil _sut;

        public StringUtilTests()
        {
            _sut = new StringUtil();
        }

        [Fact]
        public void Convert_to_byte_array_should_work_properly()
        {
            var content = File.ReadAllText(@"TestData\sample.html");
            var byteArray = _sut.Zip(content);
            var stringFromByteArray = _sut.Unzip(byteArray);

            Assert.Equal(content, stringFromByteArray);
        }
    }
}
