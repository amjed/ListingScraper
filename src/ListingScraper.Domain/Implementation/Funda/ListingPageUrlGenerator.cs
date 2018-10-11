namespace ListingScraper.Domain.Implementation.Funda
{
    public class ListingPageUrlGenerator: BaseListingPageUrlGenerator
    {
        protected override string BaseUrl { get; }

        public ListingPageUrlGenerator()
        {
            BaseUrl = "https://www.funda.nl/en/huur/amsterdam/0-1250/+10km/p{0}/";
        }
    }
}
