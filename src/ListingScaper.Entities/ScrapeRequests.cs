using System;

namespace ListingScraper.Entities
{
    public class ScrapeRequests:EntityBase
    {
        public Guid RequestId { get; set; }
        public int Pages { get; set; }
    }
}
