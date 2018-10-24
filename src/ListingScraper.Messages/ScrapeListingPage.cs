using System;
using ListingScraper.Entities.Enums;

namespace ListingScraper.Messages
{
    public class ScrapeListingPage
    {
        public Guid RequestId { get; set; }
        public Source Source { get; set; }
        public string Html { get; set; }
    }
}