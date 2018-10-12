using System.IO;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Scraping.Tests
{
    public static class PageDataHelper
    {
        public static string GetListingPage(Source source, int page)
        {
            var filename = $"{page}.html";
            var dir = $"Pages\\{source}\\Listings";
            var path = $"{dir}\\{filename}";
            if (File.Exists(path) == false)
                throw new FileNotFoundException($"page test data file {filename}not found");

            using (StreamReader sr = new StreamReader(path))
                return sr.ReadToEnd();
        }

        public static string GetListingItemPage(Source source, int page)
        {
            var filename = $"{page}.html";
            var dir = $"Pages\\{source}\\Items";
            var path = $"{dir}\\{filename}";
            if (File.Exists(path) == false)
                throw new FileNotFoundException($"page test data file {filename}not found");

            using (StreamReader sr = new StreamReader(path))
                return sr.ReadToEnd();
        }
    }
}
