namespace ListingScraper.Scraping
{
    public interface IListingPageUrlGenerator
    {
        string GetListingPage(int pageNumber);
    }
}
