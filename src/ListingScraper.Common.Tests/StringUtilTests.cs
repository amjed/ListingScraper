using System.IO;
using System.Runtime.InteropServices;
using ListingScraper.Common.Utilities;
using Xunit;

namespace ListingScraper.Common.Tests
{
    public class StringUtilTests
    {
        private readonly StringUtil _sut;
        private static char DirectorySeperator = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)? '/' : '\\';

        public StringUtilTests()
        {
            _sut = new StringUtil();
        }

        [Fact]
        public void Convert_to_byte_array_should_work_properly()
        {
            var content = File.ReadAllText($"TestData{DirectorySeperator}sample.html");
            var byteArray = _sut.Zip(content);
            var stringFromByteArray = _sut.Unzip(byteArray);

            Assert.Equal(content, stringFromByteArray);
        }
    }
}
