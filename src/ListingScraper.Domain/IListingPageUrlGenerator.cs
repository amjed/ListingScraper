namespace ListingScraper.Domain
{
    public interface IListingPageUrlGenerator
    {
        string GetListingPage(int pageNumber);
    }
}
