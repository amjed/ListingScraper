using ListingScraper.Entities;

namespace ListingScraper.Scraping
{
    public interface IListingItemPageScraper
    {
        Property GetProperty();
    }
}
