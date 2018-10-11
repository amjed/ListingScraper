using System;
using System.Collections.Generic;
using System.Text;
using ListingScraper.Entities;

namespace ListingScraper.Domain.Implementation.Funda
{
    public class ListingPageScraper: IListingPageScraper
    {
        private readonly string _pageHtml;

        public ListingPageScraper(string pageHtml)
        {
            _pageHtml = pageHtml;
        }

        public IEnumerable<ListingItem> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
