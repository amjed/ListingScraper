using System;
using System.IO;
using System.Runtime.InteropServices;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Scraping.Tests
{
    public static class PageDataHelper
    {
        private static char DirectorySeperator = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)? '/' : '\\';
        public static string GetListingPage(Source source, int page)
        {
            var filename = $"{page}.html";
            var dir = $"Pages{DirectorySeperator}{source}{DirectorySeperator}Listings";
            var path = $"{dir}{DirectorySeperator}{filename}";
            if (File.Exists(path) == false)
                throw new FileNotFoundException($"page test data file {filename}not found");

            using (StreamReader sr = new StreamReader(path))
                return sr.ReadToEnd();
        }

        public static string GetListingItemPage(Source source, int page)
        {
            var filename = $"{page}.html";
            var dir = $"Pages{DirectorySeperator}{source}{DirectorySeperator}Items";
            var path = $"{dir}{DirectorySeperator}{filename}";
            if (File.Exists(path) == false)
                throw new FileNotFoundException($"page test data file {filename}not found");

            using (StreamReader sr = new StreamReader(path))
                return sr.ReadToEnd();
        }
    }
}
