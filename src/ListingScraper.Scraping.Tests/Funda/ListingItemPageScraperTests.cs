using ListingScraper.Entities.Enums;
using ListingScraper.Scraping.Implementation.Funda;
using Xunit;

namespace ListingScraper.Scraping.Tests.Funda
{
    public class ListingItemPageScraperTests
    {
        private readonly IListingItemPageScraper _listingItemPageItemScraper;

        public ListingItemPageScraperTests()
        {
            var html = PageDataHelper.GetListingItemPage(Source.Funda, 0);

            _listingItemPageItemScraper = new ListingItemPageScraper(html);
        }

        [Fact]
        public void ShouldReturnResults()
        {
            var property = _listingItemPageItemScraper.GetProperty();
            Assert.NotNull(property);
            Assert.NotNull(property.Address);
            Assert.Equal(1200, property.Price);
            Assert.Equal(2, property.Rooms);
            Assert.Equal(45, property.AreaInSquareMeters);
            Assert.Equal("4.654095", property.Address.Longitude);
            Assert.Equal("52.32213", property.Address.Latitude);
            Assert.Equal("Rottumeroog 20 2134 ZR Hoofddorp", property.Address.FullAddress);
        }
    }
}
