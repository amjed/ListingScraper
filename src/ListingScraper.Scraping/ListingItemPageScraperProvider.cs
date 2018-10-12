using System;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Scraping
{
    public class ListingItemPageScraperProvider : IListingItemPageScraperProvider
    {
        public IListingItemPageScraper GetListingItemPageScraper(Source source, string html)
        {
            throw new NotImplementedException();
        }
    }
}