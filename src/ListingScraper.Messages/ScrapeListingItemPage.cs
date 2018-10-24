using System;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Messages
{
    public class ScrapeListingItemPage
    {
        public Guid RequestId { get; set; }
        public Source Source { get; set; }
        public string Html { get; set; }
    }
}