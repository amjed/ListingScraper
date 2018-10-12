using ListingScraper.Entities.Enums;

namespace ListingScraper.Scraping
{
    public interface IListingItemPageScraperProvider
    {
        IListingItemPageScraper GetListingItemPageScraper(Source source, string html);
    }
}