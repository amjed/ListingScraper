using System.Collections.Generic;
using ListingScraper.Entities;

namespace ListingScraper.Scraping
{
    public interface IListingPageScraper
    {
        IEnumerable<ListingItem> GetItems();
    }
}
