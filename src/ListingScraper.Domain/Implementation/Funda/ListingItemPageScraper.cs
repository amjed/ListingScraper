using System;
using ListingScraper.Entities;

namespace ListingScraper.Domain.Implementation.Funda
{
    public class ListingItemPageScraper:IListingItemPageScraper
    {
        private readonly string _pageHtml;

        public ListingItemPageScraper(string pageHtml)
        {
            _pageHtml = pageHtml;
        }

        public Property GetProperty()
        {
            throw new NotImplementedException();
        }
    }
}
