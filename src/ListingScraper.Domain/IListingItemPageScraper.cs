using ListingScraper.Entities;

namespace ListingScraper.Domain
{
    public interface IListingItemPageScraper
    {
        Property GetProperty();
    }
}
