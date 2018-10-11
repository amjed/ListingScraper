using ListingScraper.Entities.Enums;

namespace ListingScraper.Domain
{
    public interface IListingItemPageScraperProvider
    {
        IListingItemPageScraper GetListingItemPageScraper(Source source, string html);
    }
}