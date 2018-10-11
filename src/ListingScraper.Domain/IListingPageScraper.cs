using System.Collections.Generic;
using ListingScraper.Entities;

namespace ListingScraper.Domain
{
    public interface IListingPageScraper
    {
        IEnumerable<ListingItem> GetItems();
    }
}
