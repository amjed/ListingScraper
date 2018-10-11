using System;
using System.Collections.Generic;
using System.Text;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Domain
{
    public class ListingPageScraperProvider: IListingPageScraperProvider
    {
        public IListingPageScraper GetListingPageScraper(Source source, string html)
        {
            throw new NotImplementedException();
        }
    }
}
