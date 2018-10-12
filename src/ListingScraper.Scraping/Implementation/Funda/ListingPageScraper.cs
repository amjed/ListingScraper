using System.Collections.Generic;
using ListingScraper.Entities;
using Supremes;
using Supremes.Nodes;

namespace ListingScraper.Scraping.Implementation.Funda
{
    public class ListingPageScraper: IListingPageScraper
    {
        private readonly Document _document;

        public ListingPageScraper(string pageHtml)
        {
            _document = Dcsoup.Parse(pageHtml);
        }

        public IEnumerable<ListingItem> GetItems()
        {
            var result = new List<ListingItem>();
            var elements = _document.Select("div.search-result-header a");

            foreach (var element in elements)
            {
                if(element.HasAttr("data-search-result-item-anchor") == false)
                    continue;
                result.Add(new ListingItem
                {
                    Url = "https://www.funda.nl" +element.Attr("href")
                });
            }
            return result;
        }
    }
}
