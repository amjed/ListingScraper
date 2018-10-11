using System;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Domain
{
    public class ListingItemPageScraperProvider : IListingItemPageScraperProvider
    {
        public IListingItemPageScraper GetListingItemPageScraper(Source source, string html)
        {
            throw new NotImplementedException();
        }
    }
}