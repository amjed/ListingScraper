using ListingScraper.Entities.Enums;

namespace ListingScraper.Domain
{
    public interface IListingPageScraperProvider
    {
        IListingPageScraper GetListingPageScraper(Source source, string html);
    }
}