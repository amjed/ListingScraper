using ListingScraper.Entities.Enums;

namespace ListingScraper.Scraping
{
    public interface IListingPageScraperProvider
    {
        IListingPageScraper GetListingPageScraper(Source source, string html);
    }
}