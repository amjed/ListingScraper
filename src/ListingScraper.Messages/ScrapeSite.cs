using ListingScraper.Entities.Enums;

namespace ListingScraper.Messages
{
    public class ScrapeSite
    {
        public Source Source { get; set; }
        public int PageCount { get; set; }
    }
}