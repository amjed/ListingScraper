namespace ListingScraper.Scraping
{
    public abstract class BaseListingPageUrlGenerator: IListingPageUrlGenerator
    {
        protected abstract string BaseUrl { get;}

        public virtual string GetListingPage(int pageNumber)
        {
            return string.Format(BaseUrl, pageNumber);
        }
    }
}
