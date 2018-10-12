using ListingScraper.Entities.Enums;

namespace ListingScraper.Scraping
{
    public class ListingPageScraperProvider: IListingPageScraperProvider
    {
        public IListingPageScraper GetListingPageScraper(Source source, string html)
        {
            switch (source)
            {
                case Source.Funda:
                    return new Implementation.Funda.ListingPageScraper(html);
            }

            return null;
        }
    }
}
