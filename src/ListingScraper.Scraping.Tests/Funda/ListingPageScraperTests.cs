using System.Linq;
using ListingScraper.Entities.Enums;
using ListingScraper.Scraping.Implementation.Funda;
using Xunit;

namespace ListingScraper.Scraping.Tests.Funda
{
    public class ListingPageScraperTests
    {
        private readonly IListingPageScraper _listingPageScraper;

        public ListingPageScraperTests()
        {
            var html = PageDataHelper.GetListingPage(Source.Funda, 0);

            _listingPageScraper = new ListingPageScraper(html);
        }

        [Fact]
        public void ShouldReturnResults()
        {
            var items = _listingPageScraper.GetItems();
            Assert.Equal(15, items.Count());
            foreach (var listingItem in items)
            {
                Assert.False(string.IsNullOrEmpty(listingItem.Url));
            }
        }
    }
}
